using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeHTML.Strategy
{
    public class SystemStrategy : IStrategy
    {
        public object Invoke(object data)
        {
            string path = (string)data;
            return $"Getting file ({path}) from the system...";
        }
    }
}
