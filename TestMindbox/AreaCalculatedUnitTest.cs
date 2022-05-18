using MindboxTestLib;
using NUnit.Framework;
using System;
using static System.Math;

namespace TestMindbox
{
    public class Tests
    {
        AreaCalculatedManager calculatedManager;

        [SetUp]
        public void Setup()
        {
            calculatedManager = new AreaCalculatedManager();
        }

        /// <summary>
        /// Корректный рассчет площади круга.
        /// </summary>
        [Test]
        public void RightCircleAreaTest()
        {
            var radius = 3;
            var correctArea = radius * radius * PI;

            var result = calculatedManager.CalculateCircleArea(radius);

            Assert.AreEqual(result, correctArea);
        }

        /// <summary>
        /// Ошибка в значении радиуча - отрицательный радиус.
        /// </summary>
        [Test]
        public void ArgumentExceptionCircleMinusAreaTest()
        {
            var radius = -3;

            Assert.Throws<ArgumentException>(()=>calculatedManager.CalculateCircleArea(radius));
        }
        /// <summary>
        /// Ошибка в значении радиуса - нулевой радиус.
        /// </summary>
        [Test]
        public void ArgumentExceptionCircleZeroAreaTest()
        {
            var radius = 0;

            Assert.Throws<ArgumentException>(() => calculatedManager.CalculateCircleArea(radius));
        }

        /// <summary>
        /// Корректный рассчет площади треугольника.
        /// </summary>
        [Test]
        public void RightTriangleAreaTest()
        {
            var firstSide = 13;
            var secondSide = 14;
            var thirdSide = 15;
            var correctArea = 84;

            var result = calculatedManager.CalculateTriangleArea(firstSide, secondSide, thirdSide);

            Assert.AreEqual(result, correctArea);
        }

        /// <summary>
        /// Корректный рассчет площади прямугольного треугольника.
        /// </summary>
        [Test]
        public void RightRectangularTriangleAreaTest()
        {
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;
            var correctArea = 6;

            var result = calculatedManager.CalculateTriangleArea(firstSide, secondSide, thirdSide);

            Assert.AreEqual(result, correctArea);
        }

        /// <summary>
        /// Ошибка в значении стороны - отрицательная длинна.
        /// </summary>
        [Test]
        public void ArgumentExceptionTriangleMinusAreaTest()
        {
            var firstSide = 3;
            var secondSide = -4;
            var thirdSide = 5;

            Assert.Throws<ArgumentException>(() => calculatedManager.CalculateTriangleArea(firstSide, secondSide, thirdSide));
        }


        /// <summary>
        /// Ошибка в значении стороны - нулевая длинна.
        /// </summary>
        [Test]
        public void ArgumentExceptionTriangleZeroAreaTest()
        {
            var firstSide = 3;
            var secondSide = 0;
            var thirdSide = 5;

            Assert.Throws<ArgumentException>(() => calculatedManager.CalculateTriangleArea(firstSide, secondSide, thirdSide));
        }

        /// <summary>
        /// Ошибка в значении стороны - треугольник не существует.
        /// </summary>
        [Test]
        public void ArgumentExceptionTriangleNotExistAreaTest()
        {
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 15;

            Assert.Throws<ArgumentOutOfRangeException>(() => calculatedManager.CalculateTriangleArea(firstSide, secondSide, thirdSide));
        }
    }
}