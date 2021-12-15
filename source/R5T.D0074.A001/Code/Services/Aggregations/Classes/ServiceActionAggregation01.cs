using System;

using R5T.T0063;


namespace R5T.D0074.A001
{
    public class ServiceActionAggregation01 : IServiceActionAggregation01
    {
        public IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        public IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
    }
}
