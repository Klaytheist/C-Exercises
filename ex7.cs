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
            Console.WriteLine("Input the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
            Console.ReadKey();
        }
    }
}
