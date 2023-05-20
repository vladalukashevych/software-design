using AbstractFactory.WearFactory;
using AbstractFactory.WearItems.Boots;
using AbstractFactory.WearItems.Pants;

namespace AbstractFactory
{
    public class Wear
    {
        public IPants? Pants { get; set; }
        public IBoots? Boots { get; set; }

        public Wear(IWearFactory factory)
        {
            Pants = factory.MakePants();
            Boots = factory.MakeBoots();
        }

        public override string ToString()
        {
            return
                $"Pants: Number of pockets - {Pants!.PocketsNumber}\n" +
                $"\tColors: {EnumsPrinter.ToString(Pants.ItemColors)}\n" +
                $"Boots: Leather Types: {EnumsPrinter.ToString(Boots.LeatherTypes)}\n" +
                $"\tColors: {EnumsPrinter.ToString(Boots.ItemColors)}\n";
        }
    }
}