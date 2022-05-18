using System;
using static System.Math;

namespace MindboxTestLib.Models
{
    class Circle : IFigureWithArea
    {
        private double radius;

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius
        {
            get => radius;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус окружности должен быть положительным числом.");
                }
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Функция рассчета площади круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double CalculateArea()
        {      
            return PI * Pow(radius, 2);
        }
    }
}
