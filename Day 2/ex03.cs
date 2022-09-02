using System; 

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter number");
            value = int.Parse(Console.ReadLine());
            if ( value > 0 )
            {
                Console.WriteLine("Positive");
            }
            else if (  value == 0 )
            {
                Console.WriteLine("Neither positive nor negative");
            }
            else
            {
                Console.WriteLine("Negative");
            }
            Console.ReadKey();
        }
    }
}
