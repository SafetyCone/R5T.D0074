using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0074.Channels
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TaskQueue"/> implementation of <see cref="ITaskQueue"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddTaskQueue(this IServiceCollection services)
        {
            services.AddSingleton<ITaskQueue, TaskQueue>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="TaskQueue"/> implementation of <see cref="ITaskQueue"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ITaskQueue> AddTaskQueueAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ITaskQueue>(() => services.AddTaskQueue());
            return serviceAction;
        }
    }
}
