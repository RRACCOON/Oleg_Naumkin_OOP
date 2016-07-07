using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Круг
    /// </summary>
    class Disc : Round
    {
        /// <summary>
        /// Площадь круга
        /// </summary>
        public double Area
        {
            get { return Math.PI * R * R; }
        }

        public override void Show()
        {
            Console.WriteLine("Круг:");
            Console.WriteLine("Радиус = {0}", R);
            Console.WriteLine("Площадь = {0}", Area);
            Console.WriteLine("Длина = {0}", Circumference);
        }
    }
}
