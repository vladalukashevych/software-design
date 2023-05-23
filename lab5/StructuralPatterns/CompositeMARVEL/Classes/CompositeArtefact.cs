using CompositeMARVEL.Interfaces;

namespace CompositeMARVEL.Classes
{
    public class CompositeArtefact : Artefact, IArtefactContainer
    {
        private List<IArtefact> _children = new List<IArtefact>();
        public CompositeArtefact(string name, int weight, int powerBuf) : base(name, weight, powerBuf)
        {
        }

        public void AddArtefact(IArtefact artefact)
        {
            this._children.Add(artefact);
        }

        public void RemoveArtefact(IArtefact artefact)
        {
            this._children.Remove(artefact);
        }

        public override int GetWeight()
        {
            return this._children.Aggregate(this._weight, (sum, next) => sum += next.GetWeight());
        }

        public override int GetPowerBuf()
        {
            return this._children.Aggregate(this._powerBuf, (sum, next) => sum += next.GetPowerBuf());
        }

        public override int GetCount()
        {
            return this._children.Aggregate(0, (sum, next) => sum += next.GetCount());
        }
    }
}
