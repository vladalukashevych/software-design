using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Library;

namespace Proxy.Library
{
    public class SmartTextChecker : ISmartTextReader
    {
        private ISmartTextReader _reader;

        public SmartTextChecker(ISmartTextReader reader)
        {
            this._reader = reader;
        }

        public char[][]? Read()
        {
            Console.WriteLine($"Opening file {_reader.GetFileName()}");
            var text = _reader.Read();
            Console.WriteLine($"...");
            Console.WriteLine($"Closing file {_reader.GetFileName()}");
            Console.WriteLine($"Total: lines- {text.Length}, characters - {text.SelectMany(row => row).Count()}");
            return text;
        }

        public string GetFileName()
        {
            return _reader.GetFileName();
        }
    }
}
