using Decorator.Inventory;

namespace Decorator.Heroes
{
    public abstract class Hero
    {
        public string Name { get; set; }
        private int _health;
        public int Health
        {
            get { return _health; }
            set
            {
                if (value >= 0)
                    _health = value;
                else
                    _health = 0;
            }
        }

        public List<IInventoryItem> Inventory { get; protected set; }

        public Hero(string name, int health)
        {
            Name = name;
            Health = health;
            Inventory = new List<IInventoryItem>();
        }

        public bool AddInventoryItem(IInventoryItem item)
        {
            if (!Inventory.Contains(item))
                Inventory.Add(item);
            return !Inventory.Contains(item);
        }

        public bool RemoveInventoryItem(IInventoryItem item)
        {
            return Inventory.Remove(item);
        }

        public abstract void Action(int damage);

        public override string ToString()
        {
            string output = $"Health: {Health}\n";
            output += "Inventory:\n";
            foreach (IInventoryItem item in Inventory)
                output += $"\t{item.ToString()}\n";
            return output;
        }

    }
}
