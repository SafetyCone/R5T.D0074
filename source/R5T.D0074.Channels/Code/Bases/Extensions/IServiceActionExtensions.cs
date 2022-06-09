using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0074.Channels
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="TaskQueue"/> implementation of <see cref="ITaskQueue"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ITaskQueue> AddTaskQueueAction(this IServiceAction _)
        {
            var serviceAction = _.New<ITaskQueue>(services => services.AddTaskQueue());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="TaskQueueConstructor"/> implementation of <see cref="ITaskQueueConstructor"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ITaskQueueConstructor> AddTaskQueueConstructorAction(this IServiceAction _)
        {
            var serviceAction = _.New<ITaskQueueConstructor>(services => services.AddTaskQueueConstructor());
            return serviceAction;
        }
    }
}
