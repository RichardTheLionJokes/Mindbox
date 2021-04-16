using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public static class Circle
    {
        public static float Area(float radius)
        {
            if (radius <= 0) throw new ArgumentOutOfRangeException("Радиус должен иметь значение больше 0");

            return (float)Math.PI * radius * radius;
        }
    }
}
