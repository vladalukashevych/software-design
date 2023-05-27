using CompositeHTML.Strategy;

namespace CompositeHTML.LightLibrary
{
    public class LightImageNode : LightNode
    {
        public string Path { get; set; }
        public object Image
        {
            get
            {
                return _strategy.Invoke(Path);
            }
        }
        private IStrategy? _strategy;

        public LightImageNode(string path, List<string> cssClasses) :
            base("img", null, DisplayType.Block, ClosureType.None, cssClasses)
        {
            Path = path;
            GetStrategy(path);            
        }
        public override LightNode Clone()
        {
            return new LightImageNode(Path, (CssClasses.Clone() as List<string>)!);
        }
        public void GetStrategy(string path)
        {
            if (CheckPathSource.IsUrl(path))
            {
                _strategy = new InternetStrategy();
            }
            else if (CheckPathSource.IsSystem(path))
            {
                _strategy = new SystemStrategy();
            }
            else
            {                
                throw new ArgumentException("File path couldn't be defined.");               
            }
        }
    }
}
