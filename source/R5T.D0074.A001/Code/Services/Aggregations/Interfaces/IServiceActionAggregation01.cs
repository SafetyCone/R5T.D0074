using System;

using R5T.T0063;


namespace R5T.D0074.A001
{
    public interface IServiceActionAggregation01
    {
        IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
    }
}
