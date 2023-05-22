using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public class Triangle : Shape
    {
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }

        public Triangle(double a, double b, double c, string color) : base(color)
        {
            Name = "Triangle";
            A = a;
            B = b;
            C = c;
        }

    }
}
