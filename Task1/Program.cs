using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1{0}Данная программа работает с окружностью.{1}Пожалуйста задайте параметры окружности:", Environment.NewLine, Environment.NewLine);

            double x;
            double y;
            double r;

            Console.Write("Координата X = ");
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректное значение! Координата X = 0.");
                x = 0;
            }
            Console.Write("Координата Y = ");
            if (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Некорректное значение! Координата Y = 0.");
                y = 0;
            }
            Console.Write("Радиус R = ");
            if (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Некорректное значение! Радиус R = 1.");
                r = 1;
            }

            Round round = new Round(x, y, r);

            Console.WriteLine("\nКоординаты окружности ({0:0.##}; {1:0.##}){2}R = {3}", round.X, round.Y, Environment.NewLine, round.R);
            Console.WriteLine("Длина окружности = {0:0.####}", round.Circumference);
            Console.WriteLine("Площадь круга = {0:0.####}", round.Area);

            Console.WriteLine("{0}Для выхода нажмите клавишу Enter...", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
