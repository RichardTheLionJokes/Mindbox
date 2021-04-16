using System;
using FiguresLibrary;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //площадь круга
            float r = -5;
            try
            {
                Console.WriteLine("Площадь круга: " + Circle.Area(r));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //площадь треугольника по 3-м сторонам
            float[] sides = { 3, 4, 5 };
            Console.WriteLine("Площадь треугольника: " + Triangle.Area(sides));
            try
            {
                Console.WriteLine("Площадь треугольника: " + Triangle.Area(-3, 4, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //пловерка треугольника на прямоугольность
            string msg = "Треугольник со сторонами {0}, {1}, {2}";
            if (Triangle.IsRect(sides)) Console.WriteLine(msg + " прямоугольный", sides[0], sides[1], sides[2]);
            else Console.WriteLine(msg + " непрямоугольный", sides[0], sides[1], sides[2]);
            if (Triangle.IsRect(3, 4, 6)) Console.WriteLine(msg + " прямоугольный", 3, 4, 6);
            else Console.WriteLine(msg + " непрямоугольный", 3, 4, 6);

            //площадь произвольной фигуры
            (float, float)[] points = { (3, 4), (5, 11), (12, 8), (9, 5), (5, 6) };
            Console.WriteLine("Площадь фигуры: " + Figure.Area(points));
        }
    }
}
