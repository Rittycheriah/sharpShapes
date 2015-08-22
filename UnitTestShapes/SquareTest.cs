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
            var testSq = new Squares();
            testSq.Side1Top = 10;

            Assert.AreEqual(testSq.Area(), 100);
        }

        [TestMethod]
        public void SquarePerimeterTest()
        {
            var testSq = new Squares();
            testSq.Side1Top = 10;

            Assert.AreEqual(testSq.Perimeter(), 40);
        }
    }
}
