using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Line : IFigure
    {
        /// <summary>
        /// Длина линии
        /// </summary>
        public double Length { get; set; }

        public Line()
        {
            Input();
        }

        public virtual void Show()
        {
            Console.WriteLine("Линия:");
            Console.WriteLine("Длина = {0:0.##}", Length);
        }

        public virtual void Input()
        {
            Console.WriteLine("Введите длину линии : ");
            double l;
            if (!double.TryParse(Console.ReadLine(), out l)||l<=0)
            {
                Console.WriteLine("Некорректное значение! Длина = 1.");
                l = 1;
            }
            Length = l;
        }
    }
}
