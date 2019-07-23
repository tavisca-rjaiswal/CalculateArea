using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaApp
{
    public class Triangle : IShape
    {
        float b, h;
        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public double CalculateArea()
        {
            return 0.5 * b * h;
        }
    }
}
