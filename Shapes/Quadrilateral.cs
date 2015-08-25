using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape
    {
        private float side1top;
        private float side2right;
        private float side3bottom;
        private float side4left;

        public float Side1Top
        {
            get { return side1top; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side1top = value;
                }
            }
        }

        public float Side2Right
        {
            get { return side2right; }

            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side2right = value;
                }
            }
        }

        public float Side3Bottom
        {
            get { return side3bottom; }

            set {
                    if (value <= 0.0)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        side3bottom = value;
                    }
                }
            } 

        public float Side4Left
        {
          get { return side4left; }
          set {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side4left = value;
                }
            }
        }

        //public Quadrilateral(float side1top, float side2right, float side3bottom, float side4left)
        //{

        //}

        public abstract override float Area();

        public override float Perimeter()
        {
            if (Side1Top < 0 || Side2Right < 0 || Side3Bottom < 0 || Side4Left < 0)
            {
                throw new ArgumentException();
            }

            return this.Side1Top + this.Side2Right + this.Side3Bottom + this.Side4Left;
        }
    }
}
