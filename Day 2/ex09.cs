using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Input the value for X coordinate : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate : ");
            y = int.Parse(Console.ReadLine());
            if( x > 0 && y > 0 )
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else
            {
                Console.WriteLine($"The coordinate point({x},{y}) is the origin");
            }
            Console.ReadKey();
        }
    }
}
