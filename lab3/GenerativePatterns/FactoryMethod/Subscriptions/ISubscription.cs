namespace FactoryMethod.Subscriptions
{
    public interface ISubscription
    {
        string Name { get; }
        decimal MonthlyFee { get; }
        int MinimumPeriod { get; }
        List<string> Channels { get; }
        int DevicesNumber { get; }
    }
}
