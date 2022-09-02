using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter age");
            value = int.Parse(Console.ReadLine());
            if ( age >= 18 )
            {
                Console.WriteLine("Eligile to vote");
            }
            else 
            {
                Console.WriteLine("Ineligible to vote");
            }
            Console.ReadKey();
        }
    }
}
