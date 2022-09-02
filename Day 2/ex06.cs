using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter value of m");
            value = int.Parse(Console.ReadLine());
            if ( value > 0 )
            {
                Console.WriteLine("The value of n = 1");
            }
            else if ( value == 0)
            {
                Console.WriteLine("The value of n = 0");
            }
           
            else 
            {
                Console.WriteLine("The value of n = -1");
            }
            Console.ReadKey();
        }
    }
}
