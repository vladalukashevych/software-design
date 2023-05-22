using Decorator.Inventory;

namespace Decorator.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name, int health) : base(name, health) { }

        public override void Action(int damage)
        {
            Console.WriteLine("Mage is in action!");
            foreach (IInventoryItem item in Inventory)
                item.Apply(damage);
        }

        public override string ToString()
        {
            string output = $"MAGE {Name}\n";
            output += base.ToString();
            return output;
        }

    }
}
