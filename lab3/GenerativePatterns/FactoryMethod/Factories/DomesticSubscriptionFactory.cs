using FactoryMethod.Subscriptions;

namespace FactoryMethod.Factories
{
    public class DomesticSubscriptionFactory : SubscriptionFactory
    {
        ISubscription Subscription { get; }
        public DomesticSubscriptionFactory(decimal monthlyFee, int minimumPeriod,
            List<string> channels, int devicesNumber)
        {
            Subscription = new DomesticSubscription(monthlyFee, minimumPeriod, channels, devicesNumber);
        }
        public override ISubscription GetSubscription()
        {
            return Subscription;
        }
    }
}
