namespace AbstractFactory.WearItems.Pants
{
    public class MensPants : IPants
    {
        public int PocketsNumber => 6;

        public List<ItemColor> ItemColors => new List<ItemColor>()
        {
            ItemColor.Black,
            ItemColor.Grey,
            ItemColor.Orange
        };
    }
}
