using FactoryMethod.Factories;
using FactoryMethod.Subscriptions;

namespace FactoryMethod.Applications
{
    public class WebSite : IApplication
    {
        private SubscriptionFactory? _factory;

        public ISubscription GetSubscription()
        {
            Console.WriteLine("~~~ WebSite ~~~\n");
            Console.Write(" Authorization\n\tLogin: ");
            Console.ReadLine();
            Console.Write("\tPassword: ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("~~~ WebSite ~~~\n");
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
