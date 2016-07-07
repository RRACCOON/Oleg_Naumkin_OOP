using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class User
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string FatherName { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDay { get; set; }
        
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get
            {
                int temp = DateTime.Now.Year - BirthDay.Year;
                if (DateTime.Now.Month < BirthDay.Month || (DateTime.Now.Month == BirthDay.Month && DateTime.Now.Day < BirthDay.Day))
                    temp--;
                return temp;
            }
                          
            
        }
        /// <summary>
        /// Конструктор экземпляра User
        /// </summary>
        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="fathername">Отчество</param>
        public User(string surname, string name, string fathername, DateTime birthDay)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            BirthDay = birthDay;
        }

    }
}
