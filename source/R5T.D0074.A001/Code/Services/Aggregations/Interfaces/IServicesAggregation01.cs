using System;

using R5T.Dacia;


namespace R5T.D0074.A001
{
    public interface IServicesAggregation01
    {
        IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
    }
}
