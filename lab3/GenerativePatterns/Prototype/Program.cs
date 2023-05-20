using Prototype.Viruses;

Virus virus = new Virus("BigVirus", 432, 13, "Resident", null!);

VirusChild virusChild1 = new VirusChild("saveTurtles", 32, 99,
    "Polymorphic", null, DateTime.Now, virus);
VirusChild virusChild2 = new VirusChild("asamalakaduka", 42, 17,
    "Resident", null, DateTime.Now, virus);

virus.Children = new List<VirusChild> { virusChild1, virusChild2 };

Console.WriteLine(virus);

Virus virusCopy = virus.Clone() as Virus;
virus.Children.Remove(virusChild1);
virus.Name = "BIGVIRUS";
virusCopy.Name = "VirusCopy";
Console.WriteLine(virus);
Console.WriteLine(virusCopy);

VirusChild virusChild1Copy = virusChild1.Clone() as VirusChild;
Console.WriteLine(virusChild1Copy);