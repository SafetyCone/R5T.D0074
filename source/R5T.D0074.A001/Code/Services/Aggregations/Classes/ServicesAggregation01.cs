using System;

using R5T.Dacia;


namespace R5T.D0074.A001
{
    public class ServicesAggregation01 : IServicesAggregation01
    {
        public IServiceAction<ITaskQueue> TaskQueueAction { get; set; }
        public IServiceAction<ITaskQueueConstructor> TaskQueueConstructorAction { get; set; }
    }
}
