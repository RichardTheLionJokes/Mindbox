using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FiguresLibrary;

namespace FiguresUnitTests
{
    [TestClass]
    public class CircleTests
    {
        //корректность вычисления площади
        [TestMethod]
        public void TestCircArea()
        {
            float r = 2;
            float expected = 4 * (float)Math.PI;
            float actual = Circle.Area(r);
            Assert.AreEqual(expected, actual, float.Epsilon);
        }

        //проверка положительного значения радиуса
        [TestMethod]
        public void TestCircAreaNegativeArg()
        {
            float r = -5;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Circle.Area(r));
        }
    }

    [TestClass]
    public class TriangleTests
    {
        //корректность проверки на прямоугольность
        [TestMethod]
        public void TestTrRect()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            bool expected = true;
            bool actual = Triangle.IsRect(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTrRectArr()
        {
            float[] sides = { 3, 4, 5 };
            bool expected = true;
            bool actual = Triangle.IsRect(sides);
            Assert.AreEqual(expected, actual);
        }

        //проверка положительности длин сторон при проверке на прямоугольность
        [TestMethod]
        public void TestTrRectNegativeArg()
        {
            float a = 5;
            float b = 8;
            float c = -4;
            try
            {
                Triangle.IsRect(a, b, c);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.NegativeArgMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        [TestMethod]
        public void TestTrRectNegativeArgArr()
        {
            float[] sides = { 5, 8, -4 };
            try
            {
                Triangle.IsRect(sides);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.NegativeArgMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        //проверка корректности соотношения сторон при проверке на прямоугольность
        [TestMethod]
        public void TestTrRectCorSides()
        {
            float a = 10;
            float b = 2;
            float c = 1;
            try
            {
                Triangle.IsRect(a, b, c);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.IncorrectSidesMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        [TestMethod]
        public void TestTrRectCorSidesArr()
        {
            float[] sides = { 10, 2, 1 };
            try
            {
                Triangle.IsRect(sides);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.IncorrectSidesMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        //проверка количества элементов массива сторон при проверке на прямоугольность
        [TestMethod]
        public void TestTrRectArrLen()
        {
            float[] sides = { 3, 4, 5, 6 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => Triangle.IsRect(sides));
        }

        //корректность вычисления площади
        [TestMethod]
        public void TestTrArea()
        {
            float a = 3;
            float b = 4;
            float c = 5;
            float expected = 6;
            float actual = Triangle.Area(a, b, c);
            Assert.AreEqual(expected, actual, float.Epsilon);
        }

        [TestMethod]
        public void TestTrAreaArr()
        {
            float[] sides = { 3, 4, 5 };
            float expected = 6;
            float actual = Triangle.Area(sides);
            Assert.AreEqual(expected, actual, float.Epsilon);
        }

        //проверка положительности длин сторон при вычислении площади
        [TestMethod]
        public void TestTrAreaNegativeArg()
        {
            float a = 5;
            float b = 8;
            float c = -4;
            try
            {
                Triangle.Area(a, b, c);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.NegativeArgMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        [TestMethod]
        public void TestTrAreaNegativeArgArr()
        {
            float[] sides = { 5, 8, -4 };
            try
            {
                Triangle.Area(sides);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.NegativeArgMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        //проверка корректности соотношения сторон при вычислении площади
        [TestMethod]
        public void TestTrAreaCorSides()
        {
            float a = 10;
            float b = 2;
            float c = 1;
            try
            {
                Triangle.Area(a, b, c);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.IncorrectSidesMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        [TestMethod]
        public void TestTrAreaCorSidesArr()
        {
            float[] sides = { 10, 2, 1 };
            try
            {
                Triangle.Area(sides);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, Triangle.IncorrectSidesMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown!");
        }

        //проверка количества элементов массива сторон при вычислении площади
        [TestMethod]
        public void TestTrAreaArrLen()
        {
            float[] sides = { 3, 4, 5, 6 };
            Assert.ThrowsException<IndexOutOfRangeException>(() => Triangle.Area(sides));
        }
    }

    [TestClass]
    public class FigureTests
    {
        //корректность вычисления площади
        [TestMethod]
        public void TestFigArea()
        {
            (float, float)[] points = { (3, 4), (5, 11), (12, 8), (9, 5), (5, 6) };
            float expected = 30;
            float actual = Figure.Area(points);
            Assert.AreEqual(expected, actual, float.Epsilon);
        }
    }
}
