using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №2{0}Данная программа работает с треугольником.{1}Пожалуйста задайте параметры треугольниа:", Environment.NewLine, Environment.NewLine);

            double a;
            double b;
            double c;

            Console.Write("Сторона А = ");
            if (!double.TryParse(Console.ReadLine(), out a) | a<=0)
            {   
                Console.WriteLine("Некорректное значение! Сторона А = 2");
                a = 2;
            }
            Console.Write("Сторона B = ");
            if (!double.TryParse(Console.ReadLine(), out b) | b <= 0)
            {
                Console.WriteLine("Некорректное значение! Сторона B = 3");
                b = 3;
            }
            Console.Write("Сторона C = ");
            if (!double.TryParse(Console.ReadLine(), out c) | c <= 0)
            {
                Console.WriteLine("Некорректное значение! Сторона C = 4");
                c = 4;
            }


            if (a < b + c && b < a + c && c < a + b)
            {
                Triangle triangle = new Triangle(a, b, c);

                Console.WriteLine("\nСтороны треугольника A = {0:0.##}; B = {1:0.##}; C = {2:0.##};", triangle.A, triangle.B, triangle.C);
                Console.WriteLine("Периметр треугольника = {0:0.##}", triangle.Perimeter);
                Console.WriteLine("Площадь треугольника = {0:0.####}", triangle.Area);
            }
            else
            {
                Console.WriteLine("Треугольника со сторанами A = {0:0.##}; B = {1:0.##}; C = {2:0.##} - не существует", a, b, c);
            }

            Console.WriteLine("{0}Для выхода нажмите клавишу Enter...", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
