using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Library;

namespace Proxy.Library
{
    public class SmartTextReader : ISmartTextReader
    {
        private string _fileName;

        public SmartTextReader(string fileName)
        {
            this._fileName = fileName;
        }

        public char[][]? Read()
        {
            if (!File.Exists(_fileName))
            {
                Console.WriteLine($"File {_fileName} not found!");
                return null;
            }

            var lines = File.ReadAllLines(_fileName);
            var textArray = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                textArray[i] = lines[i].ToCharArray();
            }

            return textArray;
        }

        public string GetFileName()
        {
            return _fileName;
        }
    }
}
