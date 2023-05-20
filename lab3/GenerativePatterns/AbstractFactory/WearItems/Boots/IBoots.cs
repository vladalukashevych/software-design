namespace AbstractFactory.WearItems.Boots
{
    public interface IBoots : IWearItem
    {
        List<LeatherType> LeatherTypes { get; }
    }
}
