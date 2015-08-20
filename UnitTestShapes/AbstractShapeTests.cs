using System;
using Shapes;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class AbstractShapeTests
    {
        // Going down the chain --
        // Interface defines behavior (methods) : IShape

        // Abstract class added broad characteristics & properties : Shape

        // Quadrilateral (implementation) 4 sides, perimeter (add 4 sides), 
        //** Will BE ABSTRACT ^^ 

        private class MyMockShape : Shape
        {
            public override float Area()
            {
                throw new NotImplementedException();
            }

            public override float Perimeter()
            {
                throw new NotImplementedException();
            }

        }

        MyMockShape omgMyShape = new MyMockShape();

        [TestMethod]
        public void TestThatAbstractShapeClassHasFillColor()
        {
            omgMyShape.FillColor = Color.PapayaWhip;
            Assert.AreEqual(Color.PapayaWhip, omgMyShape.FillColor);
        }

        [TestMethod]
        public void TestThatAbstractShapeClassHasBorderColor()
        {
            omgMyShape.BorderColor = Color.IndianRed;
            Assert.AreEqual(Color.IndianRed, omgMyShape.BorderColor);
        }
    }
}
