using System;

namespace RefactoringExample
{
    class Extract
	{
        public static void Run()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;

            sum = Sum(numbers, sum);
            Console.WriteLine(sum);
        }

        private static int Sum(int[] numbers, int sum)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
