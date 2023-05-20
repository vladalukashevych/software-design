namespace Prototype.Viruses
{
    public class Virus : IPrototype
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public List<VirusChild> Children { get; set; }
        public Virus(string name, int weight, int age, string type, List<VirusChild> children)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Type = type;
            Children = children;
        }

        public override string ToString()
        {
            string output = $"{Name}, {Weight} bytes, {Age} days, {Type}, Children:\n";
            if (Children != null)
            {
                foreach (var child in Children)
                    output += $"\t{child}\n";
            }
            return output;
        }

        public IPrototype Clone()
        {
            return new Virus(Name, Weight, Age, Type, new List<VirusChild>(Children));
        }
    }
}
