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
            return Side1Top * Side2Right;
        }

        public override float Perimeter()
        {
            return (Side1Top * 2) + (Side2Right * 2);
        }
    }
}
