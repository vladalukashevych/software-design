using Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    public class ArmorDecorator : InventoryItemDecorator
    {
        public string Material { get; set; }

        public ArmorDecorator(IInventoryItem decoratorInventory, string material) : base(decoratorInventory)
        {
            Material = material;          
        }

        public override bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine($"{Material} {Name} fell apart. Cannot be worn anymore.");
                return false;
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"{Material} {Name} is still good. Current health - {Health}");
                return true;
            }
        }

        public override string ToString()
        {
            return $"Armor - {Material} {Name} (health. {Health})";
        }
    }
}
