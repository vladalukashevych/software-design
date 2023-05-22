using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Shape(string color)
        {
            Name = "Shape";
            Color = color;
        }

    }
}
