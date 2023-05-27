using CompositeHTML.LightLibrary;
using CompositeHTML.LightParser;

LightElementNode node =
    new LightElementNode("div", "Node", DisplayType.Block,
    new List<string>() { "white", "block" });
Console.WriteLine(node.OuterHTML());
Console.Write("\nEnter class name you want to add: ");
var css = Console.ReadLine();
Console.WriteLine();
node.AddCssClass(css);
Console.WriteLine();
Console.WriteLine(node.OuterHTML());

//LightElementNode parent =
//    new LightElementNode("div", "First Parent", DisplayType.Block, 
//    new List<string>() { "white", "block" });

//LightTextNode child1 = new LightTextNode("p", "Have an awesome day!", 
//    new List<string>() { "wishes", "popping" });
//parent.AppendChild(child1);

//LightTextNode child2 = new LightTextNode("a", "Link", 
//    new List<string>() { "link", "small-text" });
//parent.AppendChild(child2);

//LightElementNode childParent = new LightElementNode("div", "Child Parent", DisplayType.Block, 
//    new List<string>() { "child", "exquisite" });
//parent.AppendChild(childParent);

//childParent.AppendChild(child2);

//LightElementNode parentClone = (parent.Clone() as LightElementNode)!;
//parentClone.ReplaceChild(1);

//Console.WriteLine(parent.OuterHTML());
//Console.WriteLine(parentClone.OuterHTML());


//LightHTMLParser parser = new LightHTMLParser();
//WebPageLoader loader = new WebPageLoader("https://www.gutenberg.org/cache/epub/1513/pg1513.txt");
//LightElementNode node = parser.GetLightHTML(loader.GetText());

//Console.WriteLine(node.OuterHTML());
//Console.WriteLine(parser.GetObjectCount());

