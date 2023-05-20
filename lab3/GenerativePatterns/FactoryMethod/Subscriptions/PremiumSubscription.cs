namespace FactoryMethod.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public string Name { get; }
        public decimal MonthlyFee { get; }
        public int MinimumPeriod { get; }
        public List<string> Channels { get; }
        public int DevicesNumber { get; }
        public PremiumSubscription(decimal price, int minimumDayPeriod,
            List<string> channels, int countOfDevices)
        {
            Name = "Premium Subscription";
            MonthlyFee = price;
            MinimumPeriod = minimumDayPeriod;
            Channels = channels;
            DevicesNumber = countOfDevices;
        }
    }
}