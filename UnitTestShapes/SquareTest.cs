using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareAreaTest()
        {
            Squares testSq = new Squares(10);

            Assert.AreEqual(testSq.Area(), 100);
        }

        [TestMethod]
        public void SquarePerimeterTest()
        {
            Squares testSq = new Squares(10);

            Assert.AreEqual(testSq.Perimeter(), 40);
        }
    }
}
