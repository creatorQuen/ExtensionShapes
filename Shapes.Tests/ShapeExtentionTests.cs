using ExtensionShapes;
using NUnit.Framework;
using System;

namespace Shapes.Tests
{
    public class ShapeExtentionTests
    {
        [TestCase(2, 2 * 2 * Math.PI)]
        [TestCase(1, Math.PI)]
        [TestCase(7, 7 * 7 * Math.PI)]
        public void GetAreaCircleTests(double radius, double expected)
        {
            var circle = new BaseShape("Circle");
            var actual = circle.GetAreaCircle(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-1.1d)]
        public void GetAreaCircleTests_ZeroOrNegatieValue_ShouldArgumentException(double radius)
        {
            var circle = new BaseShape("Circle");
            Assert.Throws<ArgumentException>(() => circle.GetAreaCircle(radius));
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(5, 12, 13, 30)]
        [TestCase(39, 80, 89, 1560)]
        public void GetAreaTriangleTests(double sideA, double sideB, double sideC, double expected)
        {
            var triangle = new BaseShape("Triangle");
            var actual = triangle.GetAreaTriangle(sideA, sideB, sideC);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 5)]
        [TestCase(3, 0, 5)]
        [TestCase(3, 4, 0)]
        public void GetAreaTriangleTests_AnySideEqualZero_ShouldArgumentException(double sideA, double sideB, double sideC)
        {
            var triangle = new BaseShape("Triangle");
            Assert.Throws<ArgumentException>(() => triangle.GetAreaTriangle(sideA, sideB, sideC));
        }

        [TestCase(1, 1, 5)]
        [TestCase(2, 18, 5)]
        [TestCase(7, 9, 42)]
        public void GetAreaTriangleTests_ParametrTriangleLessAnySide_ShouldArgumentException(double sideA, double sideB, double sideC)
        {
            var triangle = new BaseShape("Triangle");
            Assert.Throws<ArgumentException>(() => triangle.GetAreaTriangle(sideA, sideB, sideC));
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(5, 12, 13, true)]
        [TestCase(39, 80, 89, true)]
        [TestCase(1, 1, 1, false)]
        public void IsRightTriangleTests(double sideA, double sideB, double sideC, bool expected)
        {
            var triangle = new BaseShape("Triangle");
            var actual = triangle.IsRightTriangle(sideA, sideB, sideC);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 3)]
        [TestCase(-1, 3, 4)]
        public void IsRightTriangleTests_ZeroOrNegatieValue_ShouldArgumentException(double sideA, double sideB, double sideC)
        {
            var triangle = new BaseShape("Triangle");
            Assert.Throws<ArgumentException>(() => triangle.IsRightTriangle(sideA, sideB, sideC));
        }
    }
}