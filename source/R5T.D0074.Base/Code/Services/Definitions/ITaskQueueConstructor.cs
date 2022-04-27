using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0074
{
    [ServiceDefinitionMarker]
    public interface ITaskQueueConstructor : IServiceDefinition
    {
        Task<ITaskQueue> GetNewTaskQueue();
    }
}
