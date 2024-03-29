﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0074.Channels
{
    public static partial class IServiceCollectionExtensions
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
        /// Adds the <see cref="TaskQueueConstructor"/> implementation of <see cref="ITaskQueueConstructor"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddTaskQueueConstructor(this IServiceCollection services)
        {
            services.AddSingleton<ITaskQueueConstructor, TaskQueueConstructor>();

            return services;
        }
    }
}
