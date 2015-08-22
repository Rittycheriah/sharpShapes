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
        //protected Color fillColor;
        //protected Color borderColor;

        // goal for Wednesday = pick a part of tree and implement
        // half on linked list implementation and half on tree stuff
        public Color FillColor{ get; protected set; }
        public Color BorderColor { get; protected set; }

        // it will still ask to be implemented, but this pushes it off to a child class "abstract"
        public abstract float Area();
        public abstract float Perimeter();
    }


}
