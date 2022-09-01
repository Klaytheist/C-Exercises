using System;

namespace CSExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Input the first number");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Input the second number");
            num2 = int.Parse(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping:");
            Console.WriteLine($"First number: {num1}");
            Console.WriteLine($"Second number: {num2}");
        }
    }
}
