using FactoryMethod.Factories;
using FactoryMethod.Subscriptions;

namespace FactoryMethod.Applications
{
    public class ManagerCall : IApplication
    {
        private SubscriptionFactory? _factory;
        public ISubscription GetSubscription()
        {
            Console.WriteLine("### ManagerCall ###\n");
            Console.Write(" What's your account ID?\n>>");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("### ManagerCall ###\n");
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
