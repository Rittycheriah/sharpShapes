using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{

    [TestClass]
    public class QuadrilateralTest
    {
        public class MyQuad : Quadrilateral
        {
            public override float Area()
            {
                throw new NotImplementedException(); 
            }
        }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
        public void TestQuadHasDefaultSize()
        {
            MyQuad testQuad = new MyQuad();
            testQuad.Perimeter();
        }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNoNegativeSides()
        {
            MyQuad testquad = new MyQuad();
            testquad.Side1Top = 2;
            testquad.Side2Right = 2;
            testquad.Side3Bottom = 2;
            testquad.Side4Left = -2;
        }

    [TestMethod]
        public void QuadriLateralCanComputePerimeter()
        {
            MyQuad Quad = new MyQuad();
            Quad.Side1Top = 2;
            Quad.Side2Right = 2;
            Quad.Side3Bottom = 2;
            Quad.Side4Left = 2;

            Assert.AreEqual(Quad.Perimeter(), 8);     
        }

    }
}
