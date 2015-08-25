using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            Rectangles testRectangle = new Rectangles();
            testRectangle.Side1Top = 8;
            testRectangle.Side2Right = 4;

            Assert.AreEqual(testRectangle.Area(), 32);
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            Rectangles testRectangle = new Rectangles();
            testRectangle.Side1Top = 8;
            testRectangle.Side2Right = 4;

            Assert.AreEqual(testRectangle.Perimeter(), 24);
        }
    }
}
