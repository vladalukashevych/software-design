namespace AbstractFactory.WearItems.Pants
{
    public class ChildrensPants : IPants
    {
        public int PocketsNumber => 2;

        public List<ItemColor> ItemColors => new List<ItemColor>()
        {
            ItemColor.Lilac,
            ItemColor.Lime,
            ItemColor.Orange,
            ItemColor.MintGreen,
            ItemColor.Teal
        };
    }
}
