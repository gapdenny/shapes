using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Model
{
    public class Square:Shape
    { 
        public Square(double side)
        {
            if (side <= 0)
                throw new ArgumentOutOfRangeException("Length cannot be negative or zero");
            area = side * side;
            this.side = side;
        }
        
        
    }
}
