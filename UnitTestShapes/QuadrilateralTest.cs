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
        public void QuadriLateralCanComputePerimeter()
        {
            MyQuad myTestQuad = new MyQuad();
            myTestQuad.Side1 = 2;
            myTestQuad.Side2 = 2;
            myTestQuad.Side3 = 2;
            myTestQuad.Side4 = 2;

            Assert.AreEqual(myTestQuad.Perimeter(), 8);     
        }
    }
}
