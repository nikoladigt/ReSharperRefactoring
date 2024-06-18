using System;
using System.Runtime.InteropServices;

namespace RefactoringExample
{
    class Inline
    {
        static void Run(string[] args)
        {
            double radius = 5.0;
            double area = CalculateArea(radius);

            Console.WriteLine("Area: " + area);
        }

        private static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}