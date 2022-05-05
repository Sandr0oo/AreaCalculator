using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLib.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            //Отрицательное занчение стороны треугольника
            Assert.ThrowsException<Exception>(() => new Triangle(-1, 1, 1));
            Assert.ThrowsException<Exception>(() => new Triangle(1, -1, 1));
            Assert.ThrowsException<Exception>(() => new Triangle(1, 1, -1));
            Assert.ThrowsException<Exception>(() => new Triangle(-1, -1, -1));

            //Существует ли треугольник
            Assert.ThrowsException<Exception>(() => new Triangle(1, 2, 4));
            //Assert.ThrowsException<Exception>(() => new Triangle(1, 2, 3));

        }

        [TestMethod()]
        public void GetAreaTest()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //act
            ShapesFactroy factroy = new ShapesFactroy();
            Triangle triangle = factroy.CreateTriangle(a, b, c);

            //assert
            Assert.AreEqual(expected, triangle.GetArea());
        }

        [TestMethod()]
        public void IsRightTriangleTest()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            //act
            ShapesFactroy factroy = new ShapesFactroy();
            Triangle triangle = factroy.CreateTriangle(a, b, c);

            //assert
            Assert.AreEqual(expected, triangle.IsRightTriangle());
        }
    }
}