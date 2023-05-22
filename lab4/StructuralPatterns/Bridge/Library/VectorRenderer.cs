using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public class VectorRenderer : IRenderer
    {
        public void Render(Shape shape)
        {
            Console.WriteLine($"Drawing {shape.Color} {shape.Name} as lines...");
        }
    }
}
