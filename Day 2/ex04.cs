using System; 

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter year");
            value = int.Parse(Console.ReadLine());
            if ( value % 400 == 0 )
            {
                Console.WriteLine("Leap year");
            }
            else if ( value % 100 == 0 )
            {
                Console.WriteLine("Not a leap year");
            }
            else if ( value % 4 == 0 )
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.ReadKey();
        }
    }
}
