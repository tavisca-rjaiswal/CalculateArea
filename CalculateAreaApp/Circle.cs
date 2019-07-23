using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaApp
{
    public class Circle : IShape
    {
        float radius;
        const float PIE = 3.14F;
        public Circle(float radius)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return PIE * radius * radius;
        }
    }
}
