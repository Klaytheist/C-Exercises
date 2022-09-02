using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[3];
            int largest;
            Console.WriteLine("Enter the 1st number");
            numArray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            numArray[1] = int.Parse(Console.ReadLine());
            largest = numArray[0] > numArray[1] ? 0 : 1;
            Console.WriteLine("Enter the 2nd number");
            numArray[2] = int.Parse(Console.ReadLine());
            largest = numArray[largest] > numArray[2] ? largest : 2;
            switch (largest)
            {
                case 0: Console.WriteLine("The 1st number is the greatest among three");
                    break;
                case 1:
                    Console.WriteLine("The 2nd number is the greatest among three");
                    break;
                case 2:
                    Console.WriteLine("The 3rd number is the greatest among three");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
