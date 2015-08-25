using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Squares : Rectangles
    {
        public Squares (int sideLength)
        {
            Side1Top = sideLength;
            Side2Right = sideLength;
        }
    }
}
