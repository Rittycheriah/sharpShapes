using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestsTrianglePerimeter()
        {
            Triangles myTriangle = new Triangles();
            myTriangle.side1 = 2;
            myTriangle.side2 = 3;
            myTriangle.side3 = 4;

            Assert.AreEqual(myTriangle.Perimeter(), 9);
        }

        [TestMethod]
        public void TestsTriangleArea()
        {
            Triangles myTriangle = new Triangles();
            myTriangle.side1 = 3;
            myTriangle.side2 = 4;
            myTriangle.side3 = 5;

            Assert.AreEqual(myTriangle.Area(), 6);
        }
    }
}
