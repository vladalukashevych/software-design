using AbstractFactory.WearItems.Boots;
using AbstractFactory.WearItems.Pants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WearFactory
{
    public class ChildrensClothingFactory : IWearFactory
    {
        public IBoots MakeBoots()
        {
            return new ChildrensBoots();
        }

        public IPants MakePants()
        {
            return new ChildrensPants();
        }
    }
}
