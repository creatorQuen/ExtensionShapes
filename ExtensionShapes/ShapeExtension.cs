using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionShapes
{
    public static class ShapeExtension
    {
        /// <summary>
        /// Calculate the area of a circle.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="radius"></param>
        /// <returns>The area of a circle.</returns>
        public static double GetAreaCircle(this BaseShape shape, double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be large zero");
            }

            shape.Area = Math.PI * Math.Pow(radius, 2);
            return shape.Area;
        }

        /// <summary>
        /// Calculate the area of a triangle.
        /// </summary>
        /// <param name="shape"></param>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns>The area of a triangle.</returns>
        public static double GetAreaTriangle(this BaseShape shape, double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides must be large zero");
            }

            double semiPerimeter = (sideA + sideB + sideC) / 2;

            if (semiPerimeter < sideA || semiPerimeter < sideB || semiPerimeter < sideC)
            {
                throw new ArgumentException("Semiperimeter must be large or equal any side of triangles");
            }

            shape.Area = Math.Pow((semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC)), 0.5);
            return shape.Area;
        }

        /// <summary>
        /// Verify a triangle is a right triangle.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns>Binary value.</returns>
        public static bool IsRightTriangle(this BaseShape shape, double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides must be large zero");
            }

            double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);

            return Math.Pow(maxSide, 2) == (maxSide == sideA ? (Math.Pow(sideB, 2) + Math.Pow(sideC, 2)) :
                                            maxSide == sideB ? (Math.Pow(sideA, 2) + Math.Pow(sideC, 2)) : (Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
        }
    }
}
