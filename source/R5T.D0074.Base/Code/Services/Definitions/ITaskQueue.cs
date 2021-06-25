using System;
using System.Threading.Tasks;


namespace R5T.D0074
{
    /// <summary>
    /// Allows synchronously queuing asynchronous work, with fire-and-forget processing of asynchronous work items.
    /// </summary>
    public interface ITaskQueue : IDisposable
    {
        void Enqueue(Task task);
    }
}
