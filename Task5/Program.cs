using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №5{0}Данная программа имитирует графический редактор", Environment.NewLine);

            bool exit = true;
            List<IFigure> list = new List<IFigure>();

            while (exit)
            {
                Console.WriteLine("Выберете фигуру, которую нужно создать.\nВведите:\n1 - Линию\n2 - Прямоугольник\n3 - Окружность\n4 - Круг\n5 - Кольцо\n6 - Вывод всех созданных фигур\n0 - Выход");
                string command = Console.ReadLine();
                IFigure f;
                switch (command)
                {
                    case "1":
                        f = new Line();
                        list.Add(f);
                        break;
                    case "2":
                        f = new Rectangle();
                        list.Add(f);
                        break;
                    case "3":
                        f = new Round();
                        list.Add(f);
                        break;
                    case "4":
                        f = new Disc();
                        list.Add(f);
                        break;
                    case "5":
                        f = new Ring();
                        list.Add(f);
                        break;
                    case "6":
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        foreach(IFigure fig in list)
                        {
                            Console.WriteLine("-----------------");
                            fig.Show();
                            Console.WriteLine("-----------------");
                        }                            
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    case "0":
                        exit = false;
                        break;
                }
            }
        }
    }
}
