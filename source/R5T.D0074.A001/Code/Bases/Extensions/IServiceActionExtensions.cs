using System;

using R5T.T0062;

using R5T.D0074.Channels;


namespace R5T.D0074.A001
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation01 AddTaskQueueServiceActions(this IServiceAction _)
        {
            // Level 0.
            var taskQueueAction = _.AddTaskQueueAction();
            var taskQueueConstructorAction = _.AddTaskQueueConstructorAction();

            var output = new ServiceActionAggregation01
            {
                TaskQueueAction = taskQueueAction,
                TaskQueueConstructorAction = taskQueueConstructorAction,
            };

            return output;
        }
    }
}
