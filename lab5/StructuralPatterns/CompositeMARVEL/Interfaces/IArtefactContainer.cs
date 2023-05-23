using CompositeMARVEL.Interfaces;

namespace CompositeMARVEL
{
    public interface IArtefactContainer : IArtefact
    {
        public void AddArtefact(IArtefact artefact);
        public void RemoveArtefact(IArtefact artefact);
    }
}
