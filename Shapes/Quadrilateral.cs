using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape
    {
        public float Side1Top { get; set; }
        public float Side2Right { get; set; }
        public float Side3Bottom { get; set; }
        public float Side4Left { get; set; }

        //public Quadrilateral(float side1top, float side2right, float side3bottom, float side4left)
        //{

        //}

        public abstract override float Area();

        public override float Perimeter()
        {
            if (Side1Top == 0 || Side2Right == 0 || Side3Bottom == 0 || Side4Left == 0)
            {
                throw new ArgumentException();
            }

            return this.Side1Top + this.Side2Right + this.Side3Bottom + this.Side4Left;
        }
    }
}
