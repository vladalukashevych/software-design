using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    public interface IInventoryItem
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public bool Apply(int damage);
    }
}
