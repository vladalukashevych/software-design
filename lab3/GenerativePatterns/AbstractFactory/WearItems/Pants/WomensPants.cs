namespace AbstractFactory.WearItems.Pants
{
    public class WomensPants : IPants
    {
        public int PocketsNumber => 0;

        public List<ItemColor> ItemColors => new List<ItemColor>()
        {
            ItemColor.White,
            ItemColor.MintGreen,
            ItemColor.Ruby
        };
    }
}
