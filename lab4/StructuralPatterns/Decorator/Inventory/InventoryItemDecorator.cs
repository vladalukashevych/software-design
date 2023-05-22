using Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    public abstract class InventoryItemDecorator : IInventoryItem
    {
        protected IInventoryItem _inventoryItem;
        public string Name { get; set; }
        public int Health { get; set; }

        public InventoryItemDecorator(IInventoryItem item)
        {
            _inventoryItem = item;
            Name = item.Name;
            Health = item.Health;
        }

        public abstract bool Apply(int damage);
    }
}
