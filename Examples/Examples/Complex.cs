using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class Complex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");

            string? radiusInput = Console.ReadLine();
            if (radiusInput != null)
            {
                double radius = Convert.ToDouble(radiusInput);

                double area = Area(radius);
                double circumference = Circumference(radius);

                Console.WriteLine($"The area of the circle is: {area}");
                Console.WriteLine($"The circumference of the circle is: {circumference}");
            }
        }

        private static double Circumference(double radius)
        {
            var pi = Math.PI;
            return 2 * pi * radius;
        }

        private static double Area(double radius)
        {
            var pi = Math.PI;
            return Math.PI * radius * radius;
        }
    }



}
}
