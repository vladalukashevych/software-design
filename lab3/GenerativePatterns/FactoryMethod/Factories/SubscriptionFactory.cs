using FactoryMethod.Subscriptions;

namespace FactoryMethod.Factories
{
    public abstract class SubscriptionFactory
    {
        public abstract ISubscription GetSubscription();
    }
}
