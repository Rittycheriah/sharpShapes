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
            var testRectangle = new Rectangles();
            testRectangle.Side1 = 8;
            testRectangle.Side2 = 4;

            Assert.AreEqual(testRectangle.Area(), 32);
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            var testRectangle = new Rectangles();
            testRectangle.Side1 = 8;
            testRectangle.Side2 = 4;

            Assert.AreEqual(testRectangle.Perimeter(), 24);
        }
    }
}
