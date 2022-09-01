using System;

namespace CSExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Input the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the fourth number");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Average of the inputs = {(double)(num1 + num2 + num3 + num4) / 4}");
            Console.ReadKey();
        }
    }
}
