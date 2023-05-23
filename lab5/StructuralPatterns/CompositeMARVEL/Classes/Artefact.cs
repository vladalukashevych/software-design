using CompositeMARVEL.Interfaces;

namespace CompositeMARVEL.Classes
{
    public class Artefact : IArtefact
    {
        public string Name { get; protected set; }
        protected int _weight;
        protected int _powerBuf;

        public Artefact(string name, int weight, int powerBuf)
        {
            Name = name;
            _weight = weight;
            _powerBuf = powerBuf;
        }

        public string GetName()
        {
            return Name;
        }

        public virtual int GetWeight()
        {
            return _weight;
        }

        public virtual int GetPowerBuf()
        {
            return _powerBuf;
        }

        public virtual int GetCount()
        {
            return 1;
        }
    }
}
