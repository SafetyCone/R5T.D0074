using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0074
{
    /// <summary>
    /// Allows synchronously queuing asynchronous work, with fire-and-forget processing of asynchronous work items.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ITaskQueue : IDisposable, IServiceImplementation
    {
        void Enqueue(Task task);
    }
}
