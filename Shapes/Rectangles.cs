using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangles : Quadrilateral
    {
        public override float Area()
        {
            return Side1 * Side2;
        }

        public override float Perimeter()
        {
            return (Side1 * 2) + (Side2 * 2);
        }
    }
}
