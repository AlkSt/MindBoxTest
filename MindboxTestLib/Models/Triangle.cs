using System;
using static System.Math;

namespace MindboxTestLib.Models
{
    class Triangle : IFigureWithArea
    {
        double maxSide;
        double midSide;
        double lowSide;

        /// <summary>
        /// Большая сторона треугольника
        /// </summary>
        public double MaxSide
        {
            get => maxSide;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника должна быть положительным числом.");
                }
                maxSide = value;
            }
        }

        /// <summary>
        /// Средняя  сторона треугольника
        /// </summary>
        public double MidSide
        {
            get => midSide;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника должна быть положительным числом.");
                }
                midSide = value;
            }
        }

        /// <summary>
        /// Меньшая  сторона треугольника
        /// </summary>
        public double LowSide
        {
            get => lowSide;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника должна быть положительным числом.");
                }
                lowSide = value;
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {    
            var sortedSide = new double[] { firstSide, secondSide, thirdSide };
            Array.Sort(sortedSide);
            LowSide = sortedSide[0];
            MidSide = sortedSide[1];
            MaxSide = sortedSide[2];
            
            if (!IsExistTriangle(maxSide, midSide, lowSide))
            {
                throw new ArgumentOutOfRangeException("Треугольник с такими сторонами не существует.");
            }
        }

        /// <summary>
        /// Рассчет площади треугольниника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea()
        {
            if (IsRectangularTriangle(maxSide, midSide, lowSide))
            {
                return RectangularTriangleArea(midSide, lowSide);
            }
            else
            {
                var halfMter = TriangleHalfMetr(maxSide, midSide, lowSide);
                return TriangleArea(maxSide, midSide, lowSide, halfMter);
            }
        }

        /// <summary>
        /// Функция определения существовния треугольника.
        /// </summary>
        /// <param name="maxSide">Большая сторона треугольника</param>
        /// <param name="midSide">сСредняя сторона треугольника</param>
        /// <param name="lowSide">Меньшая сторона треугольника</param>
        /// <returns>Если треугольник существует - true</returns>
        private bool IsExistTriangle(double maxSide, double midSide, double lowSide) => maxSide < midSide + lowSide;

        /// <summary>
        /// Функция определения является ли теугольник прямоугольным.
        /// </summary>
        /// <param name="maxSide">Большая сторона треугольника</param>
        /// <param name="midSide">сСредняя сторона треугольника</param>
        /// <param name="lowSide">Меньшая сторона треугольника</param>
        /// <returns>Если треугольник прямоугольный - true</returns>
        private bool IsRectangularTriangle(double maxSide, double midSide, double lowSide) => Pow(maxSide, 2) == Pow(midSide, 2) + Pow(lowSide, 2);

        /// <summary>
        /// Рассчет площади прямоугольниго треугольника.
        /// </summary>
        /// <param name="firstLeg">Первый катет</param>
        /// <param name="secondLeg">Второй катет</param>
        /// <returns></returns>
        private double RectangularTriangleArea(double firstLeg, double secondLeg) => 0.5 * firstLeg * secondLeg;

        /// <summary>
        /// Рассчет полупериметра треугольника.
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <returns>Получпериметр</returns>
        private double TriangleHalfMetr(double firstSide, double secondSide, double thirdSide) => (firstSide + secondSide + thirdSide) / 2;

        /// <summary>
        /// Рассвет площади треугольника по формуле Герона.
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <param name="halfMter">Полупериметр треугольника</param>
        /// <returns>Площадь треугольника</returns>
        private double TriangleArea(double firstSide, double secondSide, double thirdSide, double halfMter) =>
            Sqrt(halfMter * (halfMter - firstSide) * (halfMter - secondSide) * (halfMter - thirdSide));
    }
}
