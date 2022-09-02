using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Enter height(in cms)");
            height = int.Parse(Console.ReadLine());
            if ( height < 150 )
            {
                Console.WriteLine("The person is short.");
            }
            else if (height < 165)
            {
                Console.WriteLine("The person is of average height.");
            }
            else if (height < 195)
            {
                Console.WriteLine("The person is tall.");
            }
            else 
            {
                Console.WriteLine("The person is a giant");
            }
            Console.ReadKey();
        }
    }
}
