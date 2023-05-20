using FactoryMethod.Factories;
using FactoryMethod.Subscriptions;

namespace FactoryMethod
{
    public static class Helper
    {
        public static SubscriptionFactory GetFactory(string subscriptionName)
        {
            return subscriptionName.ToLower() switch
            {
                "d" => new DomesticSubscriptionFactory(13, 30, new List<string>
                {
                "Showtime Extreme", "ESPN2", "HDNet Movies", "BabyTV"
                }, 3)!,

                "e" => new EducationalSubscriptionFactory(56, 20, new List<string>
                {
                "ESPN2", "Science Channel", "Outdoor Channel", "Nature Earth", "Education TV"
                }, 2)!,
                
                "p" => new PremiumSubscriptionFactory(120, 90, new List<string>
                {
                "Showtime Extreme", "ESPN2", "OuterMax", "Nature Earth", "Education TV",
                "Starz Encore", "Animal Planet", "BabyTV", "MovieMax"
                }, 6)!,

                _ => null!
            };
        }

        public static void PrintSubscription(ISubscription subscription)
        {
            Console.WriteLine(
                $" Name: {subscription.Name}\n" +
                $" Monthly Fee: {subscription.MonthlyFee}\n" +
                $" Minimum Period: {subscription.MinimumPeriod}\n" +
                $" Devices number: {subscription.DevicesNumber}\n" +
                $" Channels:"
            );

            foreach (var chanel in subscription.Channels)
                Console.WriteLine($"\t{chanel}");
        }
    }
}
