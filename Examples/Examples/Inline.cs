using System;
using System.Runtime.InteropServices;

namespace RefactoringExample
{
    class Inline
    {
        static void Run(string[] args)
        {
            double radius = 5.0;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Area: " + area);
        }
    }
}