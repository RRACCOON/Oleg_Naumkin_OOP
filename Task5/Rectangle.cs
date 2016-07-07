using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Rectangle:IFigure
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle ()
        {
            Input();
        }
        public double Area
        {
            get { return A * B; }
        }

        public double Perimetre
        {
            get { return(A + B) * 2; }
        }

        public virtual void Show()
        {
            Console.WriteLine("Прямоугольник:");
            Console.WriteLine("Стороны : A = {0:0.##} B = {1:0.##}",A,B);
            Console.WriteLine("Площадь = {0:0.##}", Area);
            Console.WriteLine("Периметр = {0:0.##}", Perimetre);
        }

        public virtual void Input()
        {
            Console.WriteLine("Введите сторону А : ");
            double a;
            if (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Некорректное значение! A = 1.");
                a = 1;
            }
            A = a;

            Console.WriteLine("Введите сторону B : ");
            double b;
            if (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Некорректное значение! B = 1.");
                b = 1;
            }
            B = b;
        }
    }
}
