using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.MenuLibrary
{
    public class FrenchFries
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public FrenchFries()
        {
            Name = "French Fries";
            Price = 2.99m;
        }
    }
}
