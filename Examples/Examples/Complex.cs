using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Complex
    {
        static void Run(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            string radiusInput = Console.ReadLine();
            double radius = Convert.ToDouble(radiusInput);

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The circumference of the circle is: " + circumference);
        }
    }



}
}
