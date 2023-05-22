using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.MenuLibrary
{
    public class Sprite
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Sprite()
        {
            Name = "Sprite";
            Price = 1.19m;
        }
    }
}
