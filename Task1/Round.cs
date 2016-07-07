using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round
    {
        //Координаты центра круга
        public double X { get; set; }
        public double Y { get; set; }

        private double _r;
        
        //Радиус круга
        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Некорректное значение. R = 1");
                    _r = 1;
                }
                else _r = value;
            }
        }


        /// <summary>
        /// Конструктор экземпляра класса Round
        /// </summary>
        /// <param name="x">X координата центра</param>
        /// <param name="y">Y координата центра</param>
        /// <param name="r">Радиус окружности</param>
        public Round (double x, double y, double r)
        {
            X = x;
            Y = y;
            if (r <= 0)
            {
                Console.WriteLine("Радиус окружности был задан не корректно.\nРадиус = 1");
                R = 1;
            }
            else
                R = r;
        }       
        
        /// <summary>
        /// Длина окружности
        /// </summary>
        public double Circumference
        {
            get { return 2 * Math.PI * R; }
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Area
        {
            get { return Math.PI * R * R; }
        }
    }
}
