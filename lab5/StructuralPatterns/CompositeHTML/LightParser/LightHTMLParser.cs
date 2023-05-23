using CompositeHTML.LightLibrary;

namespace CompositeHTML.LightParser
{
    public class LightHTMLParser
    {
        private LightHTMLFactory _factory;

        public LightHTMLParser()
        {
            _factory = new LightHTMLFactory();
        }

        public LightElementNode GetLightHTML(string text)
        {
            text = text.Replace("\r", "");

            string[] lines = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var node = new LightElementNode("div", null, DisplayType.Block, null);

            for (int i = 0; i < lines.Length; i++)
            {
                string tagName;

                if (i == 0)
                    tagName = "h1";
                else if (lines[i].Length < 20)
                    tagName = "h2";
                else if (lines[i][0] == ' ')
                    tagName = "blockquote";
                else
                    tagName = "p";

                node.AppendChild(_factory.TextNode(tagName, lines[i], null));
            }
            return node;
        }

        public long GetObjectCount()
        {
            return _factory.ObjectCount;
        }
    }
}
