using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0074.Channels
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TaskQueue"/> implementation of <see cref="ITaskQueue"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ITaskQueue> AddTaskQueueAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ITaskQueue>(() => services.AddTaskQueue());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="TaskQueueConstructor"/> implementation of <see cref="ITaskQueueConstructor"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ITaskQueueConstructor> AddTaskQueueConstructorAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ITaskQueueConstructor>(() => services.AddTaskQueueConstructor());
            return serviceAction;
        }
    }
}
