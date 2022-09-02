using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, number = 1;
            Console.WriteLine("Enter limit");
            int limit = int.Parse(Console.ReadLine());
            Console.Clear();
            int upperLimit = 2 * limit - 1;
            for(int i = 1; i <= limit; ++i)
            {
                for(j = i-1; j < upperLimit / 2; ++j)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i; ++k, j += 2)
                {
                    Console.Write($"{number++} ");
                }
                while(j < upperLimit)
                {
                    Console.Write(" ");
                    ++j;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
