using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrossesConsoleApp.ConsoleOutputDecorators
{
    public class ColorConsoleOutput
    {
        public static void Print(string str, ConsoleColor foreGround)
        {
            Console.ForegroundColor = foreGround;
            Console.WriteLine(str);
            Console.ResetColor();
        }

        public static void Print(string str, ConsoleColor foreGround, ConsoleColor backGround)
        {
            Console.ForegroundColor = foreGround;
            Console.BackgroundColor = backGround;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
