using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public static class Figure //произвольная фигура, заданная массивом точек с координатами x, y
    {
        public static float Area((float, float)[] points)
        {
            float s = 0;
            int n = points.Length;
            //использовалась формула Гаусса
            for (int i = 0; i < n - 1; i++)
            {
                s += (points[i].Item1 * points[i + 1].Item2 - points[i].Item2 * points[i + 1].Item1);
            }
            s += (points[n - 1].Item1 * points[0].Item2 - points[n - 1].Item2 * points[0].Item1);
            s = Math.Abs(s) / 2;
            return s;
        }
    }
}
