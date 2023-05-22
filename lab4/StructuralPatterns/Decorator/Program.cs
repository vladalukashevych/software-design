using Decorator.Heroes;
using Decorator.Inventory;

Hero hero = new Warrior("Susie", 100);
IInventoryItem sword = new WeaponDecorator(new InventoryItem("Excalibur", 14), 90);
hero.AddInventoryItem(sword);

IInventoryItem armor = new ArmorDecorator(new InventoryItem("Boots", 100), "Leather");
hero.AddInventoryItem(armor);

IInventoryItem artifact = new ArtifactDecorator(new InventoryItem("Time-Turner", 67), "Portends the Way");
hero.AddInventoryItem(artifact);

Console.WriteLine(hero.ToString());
Console.WriteLine("\n\n\n");

hero.Action(15);