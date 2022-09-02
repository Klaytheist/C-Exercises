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
            if ( value % 2 == 0 )
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadKey();
        }
    }
}
