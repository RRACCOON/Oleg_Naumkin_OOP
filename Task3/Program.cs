using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №3{0}Данная программа создает пользователя{1}Пожалуйста, задайте параметры пользователя!", Environment.NewLine, Environment.NewLine);

            Console.Write("Имя пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Отчество пользователя: ");
            string fatherName = Console.ReadLine();
            Console.Write("Фамилия пользователя: ");
            string surName = Console.ReadLine();
            

            Console.Write("Введите дату рождения пользователя в формате (dd/mm/yyyy): ");
            DateTime birthDay;
            if (!DateTime.TryParse(Console.ReadLine(), out birthDay) || birthDay>DateTime.Now)
            {
                Console.WriteLine("Некорректная дата рождения\nПользователь не создан");
            }
            else
            {
                User user = new User(surName, name, fatherName, birthDay);
                Console.WriteLine("{0}Имя: {1}", Environment.NewLine, user.Name);
                Console.WriteLine("Отчество: {0}", user.FatherName);
                Console.WriteLine("Фамилия: {0}", user.Surname);
                Console.WriteLine("Возраст - {0}", user.Age);
            }

            Console.WriteLine("{0}Для выхода нажмите клавишу Enter...", Environment.NewLine);
            Console.ReadLine();
        }
    }
}
