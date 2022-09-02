using System;

namespace CSExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter the number");
            num1 = int.Parse(Console.ReadLine());
            for(int i = 0 ; i < 11 ; ++i)
            {
                Console.WriteLine($"{num1} * {i} = {num1 * i}");
            }
            Console.ReadKey();
        }
    }
}
