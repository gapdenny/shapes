using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Model
{
    public class Rectangle:Shape
    { 
        public double height;
        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                throw new ArgumentOutOfRangeException("Length cannot be negative or zero");
            area = width * height;
            this.height = height;
            this.side = width;
        }
        
    }
}
