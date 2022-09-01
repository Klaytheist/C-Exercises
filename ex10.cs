using System;

namespace CSExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Input the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Result of specified numbers {num1}, {num2} and {num3}, (x+y).z is {(num1 + num2) * num3} and x.y + y.z is {num1 * num2 + num2 * num3}");
            Console.ReadKey();
        }
    }
}
