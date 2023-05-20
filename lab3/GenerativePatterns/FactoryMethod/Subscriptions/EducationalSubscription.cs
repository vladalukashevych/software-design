namespace FactoryMethod.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public string Name { get; }
        public decimal MonthlyFee { get; }
        public int MinimumPeriod { get; }
        public List<string> Channels { get; }
        public int DevicesNumber { get; }
        public EducationalSubscription(decimal price, int minimumDayPeriod,
            List<string> channels, int countOfDevices)
        {
            Name = "Educational Subscription";
            MonthlyFee = price;
            MinimumPeriod = minimumDayPeriod;
            Channels = channels;
            DevicesNumber = countOfDevices;
        }
    }
}
