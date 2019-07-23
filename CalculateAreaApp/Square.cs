using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaApp
{
    public class Square : IShape
    {
        float side;
        public Square(float side)
        {
            this.side = side;
        }
        public double CalculateArea()
        {
            return side * side;
        }
    }
}
