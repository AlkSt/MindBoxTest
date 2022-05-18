using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestLib.Models
{
    interface IFigureWithArea
    {
        /// <summary>
        /// Рассчет площади фигуры
        /// </summary>
        /// <returns>Площадь</returns>
        public double CalculateArea();
    }
}
