using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Triangle
    {
        /// <summary>
        /// Сторона А
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Конструктор экземпляра треугольника
        /// </summary>
        /// <param name="a">Сторноа А</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter
        {
            get { return A + B + C; }
        }

        public double Area
        {
            get
            {
                double p = Perimeter / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }
}
