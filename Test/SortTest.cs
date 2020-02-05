using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Model;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class SortTest
    {
        
       

        [TestMethod]
        public void TestMethod1()
        {
            var side = 1.1234D;
            var radius = 1.1234D;
            var basel = 5D;
            var height = 2D;
            
            List<Shape> Expected = new List<Shape> { new Square(side), new Circle(radius),  new Triangle(basel, height) };
            var shapes = new List<Shape>
            {
                new Square(side),
                new Circle(radius),
                new Triangle(basel, height) };
            shapes.Sort();
           for(int i =0; i<shapes.Count;++i)
            Assert.AreEqual(Expected[i].area, shapes[i].area);

        }
    }
}

