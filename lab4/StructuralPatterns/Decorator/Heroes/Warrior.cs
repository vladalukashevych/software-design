using Decorator.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Decorator.Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name, int health) : base(name, health) { }

        public override void Action(int damage)
        {
            Console.WriteLine("Warrior is in action!");
            foreach (IInventoryItem item in Inventory)
                item.Apply(damage);
        }

        public override string ToString()
        {
            string output = $"WARRIOR {Name}\n";
            output += base.ToString();
            return output;
        }
    }
}
