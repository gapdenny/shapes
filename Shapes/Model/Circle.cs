using System;
using System.Collections.Generic;
using System.Text;


namespace Shapes.Model
{
    public class Circle:Shape
    {
        public Circle(double radius) {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Length cannot be negative or zero");
            area = radius * Math.PI;
            this.side = radius;
        }
        

    }
}
