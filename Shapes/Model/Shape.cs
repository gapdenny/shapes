using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Model
{

    abstract public class Shape:IComparable<Shape>
    {
        public double area { get; set; }
        public double side { get; set; }
        public int CompareTo(Shape other)
        {
            return this.area.CompareTo(other.area);
        }

    }
}
