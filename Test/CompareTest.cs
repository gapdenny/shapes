using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Model;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class CompareTest
    {

       

        [TestMethod]
        public void TestMethod1()
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            

            Square square = new Square(side);
            Circle circle = new Circle(radius);

            Assert.AreEqual(square.area.CompareTo(circle.area), square.CompareTo(circle));
        }

    }
}
