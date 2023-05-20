namespace AbstractFactory.WearItems.Boots
{
    public class ChildrensBoots : IBoots
    {
        public List<LeatherType> LeatherTypes => new List<LeatherType>()
                {
                    LeatherType.Cowhide,
                    LeatherType.Pigskin
                };

        public List<ItemColor> ItemColors => new List<ItemColor>()
                {
                    ItemColor.Purple,
                    ItemColor.Pink,
                    ItemColor.MintGreen
                };
    }
}
