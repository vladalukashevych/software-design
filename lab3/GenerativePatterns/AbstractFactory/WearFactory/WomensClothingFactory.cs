using AbstractFactory.WearItems.Boots;
using AbstractFactory.WearItems.Pants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WearFactory
{
    public class WomensClothingFactory : IWearFactory
    {
        public IBoots MakeBoots()
        {
            return new WomensBoots();
        }

        public IPants MakePants()
        {
            return new WomensPants();
        }
    }
}
