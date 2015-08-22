using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangles : Shape
    {
        public float side1 { get; set; }
        public float side2 { get; set; }
        public float side3 { get; set; }

        public override float Area()
        {
            float forPerimeterCalc = this.Perimeter() / 2;
            float forPA = forPerimeterCalc - side1;
            float forPB = forPerimeterCalc - side2;
            float forPC = forPerimeterCalc - side3;
            float takeSqRt = forPerimeterCalc * forPA * forPB * forPC;

            return (float)Math.Sqrt(takeSqRt);
        }

        public override float Perimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
