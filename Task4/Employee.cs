using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Employee: User
    {
        /// <summary>
        /// Опыт работы
        /// </summary>
        public byte WorkExperience { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }

        public Employee(string surname, string name, string fathername, DateTime birthDay, byte workExperience, string position) 
            : base(surname, name, fathername, birthDay)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            BirthDay = birthDay;
            WorkExperience = workExperience;
            Position = position;
        }
    }
}
