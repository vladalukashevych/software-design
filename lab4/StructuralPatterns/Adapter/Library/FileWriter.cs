using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Library
{
    public class FileWriter
    {
        private string FilePath { get; set; }

        public FileWriter(string filePath)
        {
            FilePath = filePath;
        }

        public void Write(string message)
        {
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.Write(message);
            }
        }

        public void WriteLine(string message)
        {
            using (StreamWriter sw = File.AppendText(FilePath))
            {
                sw.WriteLine(message);
            }
        }
    }
}
