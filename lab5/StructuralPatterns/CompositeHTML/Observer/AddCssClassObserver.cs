using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeHTML.Observer
{
    public class AddCssClassObserver : IObserver
    {
        public void Notify(string cssClass)
        {
            Console.WriteLine($"Css class {cssClass} has been added.");
        }
    }
}
