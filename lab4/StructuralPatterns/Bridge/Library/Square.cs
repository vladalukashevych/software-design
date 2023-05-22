using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side, string color) : base(color)
        {
            Name = "Square";
            Side = side;
        }
    }
}
