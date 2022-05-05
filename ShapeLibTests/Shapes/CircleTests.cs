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
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            Assert.ThrowsException<Exception>(() => new Circle(-1));

            Assert.ThrowsException<Exception>(() => new Circle(0));
        }

        [TestMethod()]
        public void GetAreaTest()
        {
            //arrange
            double r = 1;
            double expected = Math.PI;

            //act
            ShapesFactroy factroy = new ShapesFactroy();
            IShape circle = factroy.CreateCircle(r);

            //assert
            Assert.AreEqual(expected, circle.GetArea());
        }
    }
}