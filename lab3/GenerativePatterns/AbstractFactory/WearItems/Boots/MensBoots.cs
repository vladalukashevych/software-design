namespace AbstractFactory.WearItems.Boots
{
    public class MensBoots : IBoots
    {
        public List<LeatherType> LeatherTypes => new List<LeatherType>()
                {
                    LeatherType.Cowhide,
                    LeatherType.Elephant,
                    LeatherType.Retan
                };

        public List<ItemColor> ItemColors => new List<ItemColor>()
                {
                    ItemColor.Black,
                    ItemColor.Royal,
                    ItemColor.Purple,
                    ItemColor.Olive,
                    ItemColor.Khaki
                };
    }
}
