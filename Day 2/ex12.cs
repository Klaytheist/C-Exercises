using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Input the number (Table to be calculated) : ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
            Console.ReadKey();
        }
    }
}
