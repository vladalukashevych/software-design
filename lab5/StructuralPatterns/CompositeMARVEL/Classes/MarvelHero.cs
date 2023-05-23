using CompositeMARVEL.Interfaces;

namespace CompositeMARVEL.Classes
{
    public class MarvelHero
    {
        private List<IArtefact> _artefacts = new List<IArtefact>();
        public string Name { get; private set; }

        private int _power;
        private bool _log;

        public MarvelHero(string name, int power)
        {
            Name = name;
            _power = power;
        }

        public void AddArtefact(IArtefact artefact)
        {
            _artefacts.Add(artefact);
            if (_log)
                Console.WriteLine($"Artefact {artefact.GetName()} has been added to {Name}." +
                    $"\n\tTotal: weight - {artefact.GetWeight()}, power - {artefact.GetPowerBuf()}");
        }

        public void RemoveArtefact(IArtefact artefact)
        {
            _artefacts.Remove(artefact);
            if (_log)
                Console.WriteLine($"Artefact {artefact.GetName()} has been removed from {Name}.");
        }

        public void Strike()
        {
            int totalPower = _artefacts.Aggregate(_power, (sum, next) => sum += next.GetPowerBuf());
            Console.WriteLine($"{Name} hits with power {totalPower}");
        }

        public void CalculateArtefactsWeight()
        {
            int totalArtefactsWeight = _artefacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
            Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
        }

        public void CountArtefacts()
        {
            int totalArtefactCount = _artefacts.Count;
            Console.WriteLine($"{Name} has {totalArtefactCount} artefacts");
        }

        public void ActivateLog()
        {
            _log = true;
        }
    }

}
