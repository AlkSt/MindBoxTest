using MindboxTestLib.Models;

namespace MindboxTestLib
{
    public class AreaCalculatedManager
    {
        /// <summary>
        ///  Вычисление площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <returns></returns>
        public double CalculateCircleArea(double radius)
        {
            var circle = new Circle(radius);
            return circle.CalculateArea();
        }

        /// <summary>
        /// Вычисление площади треугольника по трем сторонам.
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <returns></returns>
        public double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            return triangle.CalculateArea();
        }

    }
}
