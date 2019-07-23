using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaApp
{
    public class Rectangle : IShape
    {
        float l, b;
        public Rectangle(float l, float b)
        {
            this.l = l;
            this.b = b;
        }
        public double CalculateArea()
        {
            return l * b;
        }
    }
}
