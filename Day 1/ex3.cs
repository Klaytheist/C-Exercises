using System;

namespace CSExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Enter two numbers:");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Quotient: {num1 / num2}");
            Console.ReadKey();
        }
    }
}
