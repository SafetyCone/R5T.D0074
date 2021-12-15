using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0074.Channels;


namespace R5T.D0074.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServicesAggregation01 AddTaskQueueServices(this IServiceCollection services)
        {
            // Level 0.
            var taskQueueAction = services.AddTaskQueueAction_Old();
            var taskQueueConstructorAction = services.AddTaskQueueConstructorAction_Old();

            return new ServicesAggregation01
            {
                TaskQueueAction = taskQueueAction,
                TaskQueueConstructorAction = taskQueueConstructorAction,
            };
        }
    }
}
