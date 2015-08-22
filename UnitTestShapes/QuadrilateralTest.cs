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
        public void QuadriLateralCanComputePerimeter()
        {
            MyQuad myTestQuad = new MyQuad();
            myTestQuad.Side1Top = 2;
            myTestQuad.Side2Right = 2;
            myTestQuad.Side3Bottom = 2;
            myTestQuad.Side4Left = 2;

            Assert.AreEqual(myTestQuad.Perimeter(), 8);     
        }

    }
}
