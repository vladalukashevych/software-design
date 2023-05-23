using Proxy.Library;

using (File.Create("no.admin")) { }
using (var file = File.CreateText("hello.txt"))
{
    file.WriteLine("Hello!");
}


var reader = new SmartTextReader("hello.txt");
var checker = new SmartTextChecker(reader);
var locker = new SmartTextReaderLocker(checker, ".admin");
Print(locker.Read());

reader = new SmartTextReader("no.admin");
locker = new SmartTextReaderLocker(reader, ".admin");
Print(locker.Read());

void Print(char[][] text)
{
    if (text != null)
    {
        foreach (var row in text)
            Console.WriteLine(new string(row));
    }
}
