using FactoryMethod.Subscriptions;

namespace FactoryMethod.Factories
{
    public class PremiumSubscriptionFactory : SubscriptionFactory
    {
        ISubscription Subscription { get; }
        public PremiumSubscriptionFactory(decimal monthlyFee, int minimumPeriod,
            List<string> channels, int devicesNumber)
        {
            Subscription = new PremiumSubscription(monthlyFee, minimumPeriod, channels, devicesNumber);
        }
        public override ISubscription GetSubscription()
        {
            return Subscription;
        }
    }
}
