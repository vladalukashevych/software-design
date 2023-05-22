using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Library
{
    public interface IRenderer
    {
        void Render(Shape shape);
    }
}
