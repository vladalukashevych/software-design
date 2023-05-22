using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.MenuLibrary
{
    public class TotalPrice
    {
        public decimal Number { get; private set; }

        public TotalPrice()
        {
            Number = 0;
        }

        public void Add(decimal value)
        {
            Number += value;
        }

        public void Reset()
        {
            Number = 0;
        }
    }
}
