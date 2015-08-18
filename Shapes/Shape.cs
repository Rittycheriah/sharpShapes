using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        // We need info about colors
        Color fillColor;
        Color borderColor;

        // goal for Wednesday = pick a part of tree and implement
        // half on linked list implementation and half on tree stuff
        public Color FillColor { get; }
        public Color BorderColor { get; }

        public float Area() { throw new NotImplementedException(); }
        public float Perimeter() { throw new NotImplementedException(); }
    }
}
