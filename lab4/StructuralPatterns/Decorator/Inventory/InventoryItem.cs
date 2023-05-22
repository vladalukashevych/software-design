using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    public class InventoryItem : IInventoryItem
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public InventoryItem(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine("The item is broken. Needs a fix to apply");
                return false;
            }
            else
            {
                Health -= damage;
                Console.WriteLine($"You have applied an item. Current health: {Health}");
                return true;
            }
        }

        public override string ToString()
        {
            return $"{Name} (heal.{Health})";
        }
    }
}
