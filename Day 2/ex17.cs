using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter limit");
            int limit = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= limit; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
