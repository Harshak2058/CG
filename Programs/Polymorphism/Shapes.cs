using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shapes
    {
        public int CalculateArea(int length, int breadth)
    {
        return length * breadth;
    }

    public double CalculateArea(double length)
    {
        return length * length;
    }

    public float CalculateArea(float breadth, float height)
    {
        return 0.5f * breadth * height;
    }
    }
}