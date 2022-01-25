using System;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace R5T.D0074.Channels
{
    // Source: https://michaelscodingspot.com/c-job-queues-with-reactive-extensions-and-channels/
    public class TaskQueue : ITaskQueue
    {
        private Channel<Task> Channel { get; }
        private ChannelWriter<Task> ChannelWriter { get; }
        private ChannelReader<Task> ChannelReader { get; }
        private Task Task { get; }


        public TaskQueue()
        {
            this.Channel = System.Threading.Channels.Channel.CreateUnbounded<Task>(); // Fully qualified name requred due to class property with the same name.
            this.ChannelReader = this.Channel.Reader;
            this.ChannelWriter = this.Channel.Writer;

            this.Task = Task.Factory.StartNew(async () =>
            {
                while (await this.ChannelReader.WaitToReadAsync())
                {
                    var task = await this.ChannelReader.ReadAsync();

                    try
                    {
                        await task;
                    }
                    catch
                    {
                        // Do nothing.
                    }
                }
            },
            TaskCreationOptions.LongRunning);
        }

        public void Enqueue(Task task)
        {
            // An unbounded queue is assumed, so can ignore the result of trying to write since it should always succeed (and will only not succeed if there's not enough system memory).
            var wroteTask = this.ChannelWriter.TryWrite(task);
            if (!wroteTask)
            {
                // Wait a bit and try again.
                System.Threading.Thread.Sleep(100);

                wroteTask = this.ChannelWriter.TryWrite(task);
                if (!wroteTask)
                {

                    throw new Exception("Unable to write task to channel.");
                }
            }
        }

        #region IDisposable

        // Source: https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/implementing-dispose#implement-the-dispose-pattern

        public void Dispose()
        {
            this.Dispose(true);

            GC.SuppressFinalize(this);
        }

        private bool zDisposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (this.zDisposed)
            {
                return;
            }

            if (disposing)
            {
                this.Task.Dispose();
                this.Channel.Writer.Complete();
            }

            this.zDisposed = true;
        }

        ~TaskQueue() => this.Dispose(false);

        #endregion
    }
}
