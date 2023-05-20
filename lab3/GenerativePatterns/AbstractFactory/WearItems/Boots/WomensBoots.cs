namespace AbstractFactory.WearItems.Boots
{
    public class WomensBoots : IBoots
    {
        public List<LeatherType> LeatherTypes => new List<LeatherType>()
                {
                    LeatherType.Cowhide,
                    LeatherType.Retan,
                    LeatherType.Sharkskin
                };

        public List<ItemColor> ItemColors => new List<ItemColor>()
                {
                    ItemColor.Black,
                    ItemColor.Teal,
                    ItemColor.Lilac,
                    ItemColor.Teal,
                    ItemColor.Peach,
                    ItemColor.White,
                    ItemColor.Pink,
                    ItemColor.Ruby
                };
    }
}
