using System;

namespace EventBus
{
    public class SubscriptionInfo
    {
        public bool IsDynamic { get; }

        public Type HandlerType { get; }

        private SubscriptionInfo(bool isDymanic, Type handlerType)
        {
            IsDynamic = isDymanic;
            HandlerType = handlerType;
        }

        public static SubscriptionInfo Dynamic(Type handlerType) => new(true, handlerType);

        public static SubscriptionInfo Typed(Type handlerType) => new(false, handlerType);
    }
}