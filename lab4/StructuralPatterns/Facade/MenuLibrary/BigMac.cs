using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.MenuLibrary
{
    public class BigMac
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public BigMac()
        {
            Name = "BigMac";
            Price = 4.99m;
        }
    }
}
