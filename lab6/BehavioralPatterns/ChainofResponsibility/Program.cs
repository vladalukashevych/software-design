using ChainOfResponsibility.HandlerLibrary;

var handler1 = new FirstHandler();
var handler2 = new SecondHandler();
var handler3 = new ThirdHandler();
var handler4 = new FourthHandler();

handler1.SetNext(handler2);
handler2.SetNext(handler3);
handler3.SetNext(handler4);

bool flag = false;
do
{
    if (flag)
        Console.WriteLine("\n\n Please, enter the number from the list.\n");
    Console.WriteLine(" 1 - Customer service" +
    "\n 2 - Sales and revenue" +
    "\n 3 - Security support" +
    "\n 4 - Administration support\n");
    Console.Write(">> ");

    int num;
    int.TryParse(Console.ReadLine(), out num);
    var res = handler1.Handle(num);
    if (res is string)
    {
        Console.WriteLine("\n " + res);
        flag = false;
    }
    else
    {
        flag = true;
    }

} while (flag);
