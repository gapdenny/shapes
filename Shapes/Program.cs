using System;
using System.Collections.Generic;
using Shapes.Model;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var side = 1.1234D;
            var radius = 1.1234D;
            var basel = 5D;
            var height = 2D;
            try
            {
                var shapes = new List<Shape>
            {
                new Triangle(basel, height),
                new Square(side),
                new Circle(radius)
                 };
                shapes.Sort();

                foreach (var el in shapes)
                {
                    Console.WriteLine(el.area);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }       
            
            
        }
    }
}
