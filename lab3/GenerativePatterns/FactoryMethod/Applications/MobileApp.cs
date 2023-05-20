using FactoryMethod.Factories;
using FactoryMethod.Subscriptions;

namespace FactoryMethod.Applications
{
    public class MobileApp : IApplication
    {
        private SubscriptionFactory? _factory;
        public ISubscription GetSubscription()
        {
            Console.WriteLine("--- MobileApp ---\n");
            Console.WriteLine(" What subscription would you like? ");
            Console.WriteLine("> d - Domestic");
            Console.WriteLine("> e - Educational");
            Console.WriteLine("> p - Premium");

            Console.Write("\n>>");

            string subscriptionName = Console.ReadLine()!;
            _factory = Helper.GetFactory(subscriptionName);

            return _factory.GetSubscription();
        }
    }
}
