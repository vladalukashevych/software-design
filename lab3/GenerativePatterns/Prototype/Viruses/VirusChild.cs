namespace Prototype.Viruses
{
    public class VirusChild : Virus
    {
        public DateTime BirthDate { get; set; }
        public Virus Parent { get; set; }

        public VirusChild(string name, int weight, int age, string type,
            List<VirusChild> children, DateTime birthDate, Virus parent) : base(name, weight, age, type, children)
        {
            this.BirthDate = birthDate;
            Parent = parent;
        }

        public override string ToString()
        {
            return $"{Name}, {Weight} bytes, {Age} days, {Type}, {BirthDate}";
        }

        public IPrototype Clone()
        {
            return new VirusChild(Name, Weight, Age, Type, new List<VirusChild>(Parent.Children), BirthDate, Parent);
        }
    }
}
