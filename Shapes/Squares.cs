using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Squares : Quadrilateral
    {
        public override float Area()
        {
            return Side1Top * Side1Top;
        }

        public override float Perimeter()
        {
            return Side1Top * 4;
        }
    }
}
