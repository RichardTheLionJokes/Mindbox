using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public static class Triangle
    {
        public const string NegativeArgMessage = "Negative side length!";
        public const string IncorrectSidesMessage = "Incorrect sides ratio!";

        //площадь треугольника по трем сторонам
        public static float Area(float a, float b, float c)
        {
            return TrArea(a, b, c);
        }

        //площадь треугольника по массиву длин сторон
        public static float Area(float[] sides)
        {
            if (sides.Length != 3) throw new IndexOutOfRangeException("Triangle must have 3 sides");
            return TrArea(sides[0], sides[1], sides[2]);
        }

        static float TrArea(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentOutOfRangeException("sides", NegativeArgMessage);
            if (!CorrectSides(a, b, c)) throw new ArgumentOutOfRangeException("sides", IncorrectSidesMessage);
            float p = (a + b + c) / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //проверка треугольника на прямоугольность по трем сторонам
        public static bool IsRect(float a, float b, float c)
        {
            return TrIsRect(a, b, c);
        }

        //проверка треугольника на прямоугольность по массиву длин сторон
        public static bool IsRect(float[] sides)
        {
            if (sides.Length != 3) throw new IndexOutOfRangeException("Triangle must have 3 sides");
            return TrIsRect(sides[0], sides[1], sides[2]);
        }

        static bool TrIsRect(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentOutOfRangeException("sides", NegativeArgMessage);
            if (!CorrectSides(a, b, c)) throw new ArgumentOutOfRangeException("sides", IncorrectSidesMessage);
            float x;
            if (b > a) { x = a; a = b; b = x; }
            if (c > a) { x = a; a = c; c = x; }
            if (a * a == b * b + c * c) return true;
            else return false;
        }

        //проверка условия "Любая сторона треугольника меньше суммы двух других сторон и больше их разности"
        static bool CorrectSides(float a, float b, float c)
        {
            if ((a < b + c) && (a > b - c) && (b < a + c) && (b > a - c) && (c < a + b) && (c > a - b))
            { return true; }
            else { return false; }
        }
    }
}
