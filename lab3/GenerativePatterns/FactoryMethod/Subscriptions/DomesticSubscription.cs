namespace FactoryMethod.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public string Name { get; }
        public decimal MonthlyFee { get; }
        public int MinimumPeriod { get; }
        public List<string> Channels { get; }
        public int DevicesNumber { get; }
        public DomesticSubscription(decimal price, int minimumDayPeriod,
            List<string> channels, int countOfDevices)
        {
            Name = "Domestic Subscription";
            MonthlyFee = price;
            MinimumPeriod = minimumDayPeriod;
            Channels = channels;
            DevicesNumber = countOfDevices;
        }
    }
}
