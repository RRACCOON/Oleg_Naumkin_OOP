using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Ring:Round
    {
       
        public double InR { get; set; }

        public double InCircumference
        {
            get { return 2 * Math.PI * InR; }
        }
        public override void Show()
        {
            Console.WriteLine("Кольцо:");
            base.Show();
            Console.WriteLine("Внутренняя окружность:");
            Console.WriteLine("Радиус  = {0:0.##}", InR);
            Console.WriteLine("Длина  = {0:0.##}", InCircumference);
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Введите  радиус  внутренней окружности: ");
            double r;
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0 || r>=R)
            {
                Console.WriteLine("Некорректное значение! Радиус внутренней окружности будет вдвое меньше внешнего");
                r = R / 2;
            }
            InR = r;
        }
    }
}
