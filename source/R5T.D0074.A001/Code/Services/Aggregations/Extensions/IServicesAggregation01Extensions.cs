using System;

using R5T.D0074.A001;


namespace System
{
    public static class IServicesAggregation01Extensions
    {
        public static T FillFrom<T>(this T aggregation,
            IServicesAggregation01 other)
            where T : IServicesAggregation01
        {
            aggregation.TaskQueueAction = other.TaskQueueAction;
            aggregation.TaskQueueConstructorAction = other.TaskQueueConstructorAction;

            return aggregation;
        }
    }
}
