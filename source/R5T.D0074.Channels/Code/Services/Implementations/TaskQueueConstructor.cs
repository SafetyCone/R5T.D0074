using System;
using System.Threading.Tasks;


namespace R5T.D0074.Channels
{
    public class TaskQueueConstructor : ITaskQueueConstructor
    {
        public Task<ITaskQueue> GetNewTaskQueue()
        {
            var taskQueue = new TaskQueue();

            return Task.FromResult(taskQueue as ITaskQueue);
        }
    }
}
