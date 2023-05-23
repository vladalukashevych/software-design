using CompositeMARVEL.Interfaces;

namespace CompositeMARVEL.Classes
{
    public class ArtefactContainer : IArtefactContainer
    {
        public string Name { get; private set; }
        private List<IArtefact> _children = new List<IArtefact>();

        public ArtefactContainer(string name)
        {
            Name = name;
        }

        public void AddArtefact(IArtefact artefact)
        {
            this._children.Add(artefact);
        }

        public void RemoveArtefact(IArtefact artefact)
        {
            this._children.Remove(artefact);
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetWeight()
        {
            return _children.Sum((next) => next.GetWeight());
        }

        public int GetPowerBuf()
        {
            return _children.Sum((next) => next.GetPowerBuf());
        }

        public int GetCount()
        {
            return _children.Sum((next) => next.GetCount());
        }
    }
}
