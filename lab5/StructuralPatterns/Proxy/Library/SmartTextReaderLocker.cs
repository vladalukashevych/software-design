using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Proxy.Library;

namespace Proxy.Library
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private ISmartTextReader _reader;
        private string _regex;

        public SmartTextReaderLocker(ISmartTextReader textReader, string regex)
        {
            this._reader = textReader;
            _regex = regex;
        }

        public char[][]? Read()
        {
            if (Regex.IsMatch(GetFileName(), _regex))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return _reader.Read();
        }

        public string GetFileName()
        {
            return _reader.GetFileName();
        }
    }
}
