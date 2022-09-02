using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Input upto the table number starting from 1 : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication table from 1 to {number}");
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{j}*{i} = {j * i}{(j == 10 ? "": ",")} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
