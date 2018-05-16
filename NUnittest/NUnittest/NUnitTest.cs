using GeometricFigures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest1
{
    [TestFixture]
    public class Lab_5_NUnit
    {

        static object[] CircleCase =
       {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        static object[] TriangleCase =
        {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        static object[] SquareCase =
        {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 }

        };

        [Test, TestCaseSource("CircleCase")]
        public void GetAreaCirclePositiveTest(int r)
        {
            Circle circle = new Circle(r);
            double c_area = Math.Round(Math.PI * r * r, 3);
            double mc_area = Math.Round(circle.getAreaCircle(), 3);
            Assert.AreEqual(c_area, mc_area, "Метод возвращает неверное значение площади круга при радиусе равном {0}", r);
        }

        [Test, TestCaseSource("CircleCase")]
        public void GetLengthCirclePositiveTest(int r)
        {
            Circle circle = new Circle(r);
            double c_length = Math.Round(2 * Math.PI * r, 3);
            double mc_length = Math.Round(circle.getLengthCircle(), 3);
            Assert.AreEqual(c_length, mc_length, "Метод возвращает неверное значение длины окружности при радиусе равном {0}", r);
        }

        [Test, TestCaseSource("SquareCase")]
        public void GetAreaSquarePositiveTest(int a)
        {
            Square square = new Square(a);
            int s_area = a * a;
            double ms_area = square.getAreaSquare();
            Assert.AreEqual(s_area, ms_area, "Метод возвращает неверное значение площади квадрата при стороне равной {0}", a);
        }

        [Test, TestCaseSource("SquareCase")]
        public void GetLengthSquarePositiveTest(int a)
        {
            Square square = new Square(a);
            int s_length = a * 4;
            double ms_length = square.getLengthSquare();
            Assert.AreEqual(s_length, ms_length, "Метод возвращает неверное значение периметра квадрата при стороне равной {0}", a);
        }

        [Test, TestCaseSource("TriangleCase")]
        public void GetAreaTrianglePositiveTest(int b)
        {
            Triangle triangle = new Triangle(b, b, b);
            double halfP = (double)(b + b + b) / 2;
            double t_area = Math.Round(
            Math.Pow(halfP * (halfP - b) * (halfP - b) * (halfP - b)
            , 0.5), 5);
            double mt_area = Math.Round(triangle.getAreaTriangle(), 5);
            Assert.AreEqual(t_area, mt_area, "Метод возвращает неверное значение площади треугольника при условии " +
                "что \n сторона1  = {0}\n сторона2 = {1}\n сторона3 = {2}", b, b, b);

            
        }

        [Test, TestCaseSource("TriangleCase")]
        public void GetLengthTrianglePositiveTest(int b)
        {
            Triangle triangle = new Triangle(b, b, b);
            double t_length = b + b + b;
            double mt_length = triangle.getLengthTriangle();
            Assert.AreEqual(t_length, mt_length, "Метод возвращает неверное значение периметра треугольника при условии" +
                " что \n сторона1 = {0}\n сторона2 = {1}\n сторона3 = {2}", b, b, b);
        }
    }
}
