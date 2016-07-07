using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №4{0}Данная программа создает сотрудника на основе пользователя{1}Пожалуйста, задайте параметры сотрудника!", Environment.NewLine, Environment.NewLine);

            Console.Write("Имя сотрудника: ");
            string name = Console.ReadLine();
            Console.Write("Отчество сотрудника: ");
            string fatherName = Console.ReadLine();
            Console.Write("Фамилия сотрудника: ");
            string surName = Console.ReadLine();

            Console.Write("Введите дату рождения сотрудника в формате (dd/mm/yyyy): ");
            DateTime birthDay;
            if (!DateTime.TryParse(Console.ReadLine(), out birthDay) || birthDay > DateTime.Now)
            {
                Console.WriteLine("Некорректная дата рождения\nСотрудник не создан");
            }
            else
            {
                Console.Write("Должность сотрудника: ");
                string position = Console.ReadLine();

                Console.Write("Полных лет опыта работы сотрудника: ");
                byte exp;
                if (!byte.TryParse(Console.ReadLine(), out exp))
                {
                    Console.WriteLine("Некорректное значения опыта работы. Опыта работы: нет");
                    exp = 0;
                }

                Employee human = new Employee(surName, name, fatherName, birthDay, exp, position);
                Console.WriteLine("{0}Имя: {1}", Environment.NewLine, human.Name);
                Console.WriteLine("Отчество: {0}",human.FatherName);
                Console.WriteLine("Фамилия: {0}", human.Surname);
                Console.WriteLine("Возраст - {0}", human.Age);
                Console.WriteLine("Должность: {0}", human.Position);
                if (human.WorkExperience == 0)
                {
                    Console.WriteLine("Опыта работы нет, либо менее 1 года");
                }
                else
                {   //Можно прописать Case на корректное отображение "Года/Год/Лет"
                    Console.WriteLine("Опыт работы - {0} года/лет", human.WorkExperience);
                }
            }

            Console.WriteLine("{0}Для выхода нажмите клавишу Enter...", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
