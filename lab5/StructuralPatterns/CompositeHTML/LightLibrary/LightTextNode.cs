namespace CompositeHTML.LightLibrary
{
    public class LightTextNode : LightNode
    {
        public LightTextNode(string tagName, string text, List<string> cssClasses) :
            base(tagName, text, DisplayType.Inline, ClosureType.Closing, cssClasses)
        {
        }

        public override LightNode Clone()
        {
            return new LightTextNode(TagName, Text, (CssClasses.Clone() as List<string>)!);
        }
    }
}
