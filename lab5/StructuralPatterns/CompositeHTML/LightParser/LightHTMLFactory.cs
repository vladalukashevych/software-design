using CompositeHTML.LightLibrary;

namespace CompositeHTML.LightParser
{
    public class LightHTMLFactory
    {
        private readonly Dictionary<string, LightNode> _nodes = new();
        public int ObjectCount { get; private set; }

        public LightNode TextNode(string tagName, string text, List<string> cssClasses)
        {
            string key = $"{tagName}:{text}";

            if (_nodes.ContainsKey(key))
                return _nodes[key];

            ++ObjectCount;
            var newNode = new LightTextNode(tagName, text, cssClasses);
            _nodes.Add(key, newNode);

            return newNode;
        }
    }
}
