using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public static class Circle
    {
        //площадь круга
        public static float Area(float radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException("radius", "Radius must be greater than 0");

            return (float)Math.PI * radius * radius;
        }
    }
}
