using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    public class WeaponDecorator : InventoryItemDecorator
    {
        public int Power { get; set; }

        public WeaponDecorator(IInventoryItem decoratorInventory, int power) : base(decoratorInventory)
        {
            Power = power;
        }

        public override bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine($"{Name} Weapon is broken! Requires repair.");
                return false;
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"{Name} is still good. Current health - {Health}");
                return true;
            }
        }

        public override string ToString()
        {
            return $"Weapon - {Name} {Power} power (health. {Health})";
        }
    }
}
