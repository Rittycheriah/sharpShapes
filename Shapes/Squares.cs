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
            return Side1 * Side1;
        }

        public override float Perimeter()
        {
            return Side1 * 4;
        }
    }
}
