using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Окружность
    /// </summary>
    class Round: IFigure
    {
        //Радиус круга
        public double R { get; set; }
        
        public Round()
        {
            Input();
        }
        /// <summary>
        /// Конструктор экземпляра класса Round
        /// </summary>        
        /// <param name="r">Радиус окружности</param>             
        
        /// <summary>
        /// Длина окружности
        /// </summary>
        public double Circumference
        {
            get { return 2 * Math.PI * R; }
        }

        public virtual void Show()
        {
            Console.WriteLine("Окружность:");
            Console.WriteLine("Радиус = {0}", R);
            Console.WriteLine("Длина = {0}", Circumference);
        }

        public virtual void Input()
        {
            Console.WriteLine("Введите  радиус окружности: ");
            double r;
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Некорректное значение! Радиус = 1.");
                r = 1;
            }
            R = r;
        }
    }
}
