using System;
using System.Linq;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int[] numArray;
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());
            numArray = new int[number];
            for(int i = 0; i < number; ++i)
            {
                numArray[i] = 2 * (i + 1) - 1; 
            }
            Console.Write("The odd numbers are: ");
            for(int i = 0; i < number; ++i)
            {
                Console.Write($"{numArray[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"The sum of odd natural numbers upto {number} terms: {numArray.Sum()}");
            Console.ReadKey();
        }
    }
}
