using FactoryMethod.Subscriptions;

namespace FactoryMethod.Factories
{
    public class EducationalSubscriptionFactory : SubscriptionFactory
    {
        ISubscription Subscription { get; }
        public EducationalSubscriptionFactory(decimal monthlyFee, int minimumPeriod,
            List<string> channels, int devicesNumber)
        {
            Subscription = new EducationalSubscription(monthlyFee, minimumPeriod, channels, devicesNumber);
        }
        public override ISubscription GetSubscription()
        {
            return Subscription;
        }
    }
}
