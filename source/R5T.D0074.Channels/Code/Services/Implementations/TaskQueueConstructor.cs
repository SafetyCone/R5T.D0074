using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0074.Channels
{
    [ServiceImplementationMarker]
    public class TaskQueueConstructor : ITaskQueueConstructor, IServiceImplementation
    {
        public Task<ITaskQueue> GetNewTaskQueue()
        {
            var taskQueue = new TaskQueue();

            return Task.FromResult(taskQueue as ITaskQueue);
        }
    }
}
