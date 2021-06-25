using System;
using System.Threading.Tasks;


namespace R5T.D0074
{
    public interface ITaskQueueConstructor
    {
        Task<ITaskQueue> GetNewTaskQueue();
    }
}
