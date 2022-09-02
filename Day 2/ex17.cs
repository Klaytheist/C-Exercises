using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            Console.WriteLine("Enter limit");
            int limit = int.Parse(Console.ReadLine());
            Console.Clear();
            int upperLimit = 2 * limit - 1;
            for(int i = 1; i <= limit; ++i, ++number)
            {
                for(int j = 0; j < i; ++j)
                {
                    Console.Write($"{number}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
