using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Library
{
    public interface ISmartTextReader
    {
        char[][]? Read();
        string GetFileName();
    }
}
