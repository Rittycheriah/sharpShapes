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

        public class MyMockShape : Shape
        {
            public MyMockShape()
            {
                BorderColor = Color.IndianRed;
                FillColor = Color.PapayaWhip;
            }

            public override float Area()
            {
                throw new NotImplementedException();
            }

            public override float Perimeter()
            {
                throw new NotImplementedException();
            }

        }

        [TestMethod]
        public void TestThatAbstractShapeClassHasFillColor()
        {
            MyMockShape testShape = new MyMockShape();
            Assert.AreEqual(Color.PapayaWhip, testShape.FillColor);
        }

        [TestMethod]
        public void TestThatAbstractShapeClassHasBorderColor()
        {
            MyMockShape testShape = new MyMockShape();
            Assert.AreEqual(Color.IndianRed, testShape.BorderColor);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasArea()
        {
            MyMockShape testShape = new MyMockShape();
            testShape.Area();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasPerimeter()
        {
            MyMockShape testShape = new MyMockShape();
            testShape.Perimeter();
        }
    }
}
