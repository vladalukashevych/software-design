using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.MenuLibrary
{
    public class Napkins
    {
        private decimal _cost = 0.03m;
        public decimal Price;
        public Napkins(int amount)
        {
            Price = amount * _cost;
        }
    }
}
