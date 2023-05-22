using Decorator.Inventory;

namespace Decorator.Heroes
{
    public class Paladin : Hero
    {
        public Paladin(string name, int health) : base(name, health) { }

        public override void Action(int damage)
        {
            Console.WriteLine("Paladin is in action!");
            foreach (IInventoryItem item in Inventory)
                item.Apply(damage);
        }

        public override string ToString()
        {
            string output = $"PALADIN {Name}\n";
            output += base.ToString();
            return output;
        }
    }
}
