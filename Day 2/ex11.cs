using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.Write("Input number of terms : ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Number is {i} and cube is {Math.Pow(i, 3)}");
            }
            Console.ReadKey();
        }
    }
}
