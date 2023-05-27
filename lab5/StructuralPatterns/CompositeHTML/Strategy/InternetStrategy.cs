using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeHTML.Strategy
{
    public class InternetStrategy : IStrategy
    {
        public object Invoke(object data)
        {
            string path = (string)data;
            return $"Downloading file ({path}) from the internet...";
        }
    }
}
