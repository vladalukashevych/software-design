using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, string color) : base(color)
        {
            Name = "Circle";
            Radius = radius;
        }

    }
}
