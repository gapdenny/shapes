using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Model
{
    public class Triangle:Shape
    {
        public double heigth;
        public Triangle(double baseline, double heigth)
        {
            if (baseline <= 0 || heigth <= 0)
                throw new ArgumentOutOfRangeException("Length cannot be negative or zero");

            area = baseline * heigth / 2;
            this.side = baseline;
            this.heigth = heigth;
        }
        
    }
}
