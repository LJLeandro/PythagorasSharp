using System;
using System.Collections.Generic;
using System.Text;

namespace LJLeandro.PythagorasSharp.Formulas
{
    /// <summary>
    /// Area Formulas
    /// </summary>
    public static class Area
    {
        /// <summary>
        /// Square Area | Area = length * length 
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static double CalculateSquareArea(double length)
        {
            return Math.Pow(length, 2);
        }
        
        /// <summary>
        /// Rectangle Area | Area = width * height
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }

        /// <summary>
        /// Circle Area | Area = PI * (radius * radius)
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// Triangle Area | Area = (baseTriangle * height) / 2
        /// </summary>
        /// <param name="height"></param>
        /// <param name="baseTriangle"></param>
        /// <returns></returns>
        public static double CalculateTriangleArea(double height, double baseTriangle)
        {
            return (baseTriangle * height) / 2;
        }

        /// <summary>
        /// Parallelogram Area | Area = baseParallelogram * height
        /// </summary>
        /// <param name="baseParallelogram"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double CalculateParallelogramArea(double baseParallelogram, double height)
        {
            return baseParallelogram * height;
        }

        /// <summary>
        /// Trapezoid or Trapezium Area | Area = ((majorParallelSide + minorParallelSide) / 2) * height
        /// </summary>
        /// <param name="height"></param>
        /// <param name="majorParallelSide"></param>
        /// <param name="minorParallelSide"></param>
        /// <returns></returns>
        public static double calculateTrapezoidOrTrapeziumArea(double height, double majorParallelSide, double minorParallelSide)
        {
            return ((majorParallelSide + minorParallelSide) / 2) * height;
        }
    }
}
