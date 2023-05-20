using AbstractFactory.WearItems.Boots;
using AbstractFactory.WearItems.Pants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WearFactory
{
    public class MensClothingFactory : IWearFactory
    {
        public IBoots MakeBoots()
        {
            return new MensBoots();
        }

        public IPants MakePants()
        {
            return new MensPants();
        }
    }
}
