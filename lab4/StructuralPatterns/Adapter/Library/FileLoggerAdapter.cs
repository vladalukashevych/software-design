using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Library
{
    public class FileLoggerAdapter : Logger
    {
        private FileWriter _fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            _fileWriter.WriteLine($"Log: {message}");
        }

        public void Error(string message)
        {
            _fileWriter.WriteLine($"Error: {message}");
        }

        public void Warn(string message)
        {
            _fileWriter.WriteLine($"Warn: {message}");
        }
    }
}
