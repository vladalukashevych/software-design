using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Inventory
{
    public class ArtifactDecorator : InventoryItemDecorator
    {
        public string Effect { get; set; }

        public ArtifactDecorator(IInventoryItem decoratorInventory, string effect) : base(decoratorInventory)
        {
            Effect = effect;            
        }
        public override bool Apply(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine($"{Name} Artifact lost its magic! Cannot be used.");
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
            return $"Artifact - {Name} with {Effect} effect (health. {Health})";
        }
    }
}
