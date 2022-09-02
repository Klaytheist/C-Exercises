using System;

namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int math, phy, chem;
            Console.Write("Input marks obtaind in maths: ");
            math = int.Parse(Console.ReadLine());
            Console.Write("Input marks obtaind in physics: ");
            phy = int.Parse(Console.ReadLine());
            Console.Write("Input marks obtaind in chemistry: ");
            chem = int.Parse(Console.ReadLine());
            if ( math >= 65 && phy >= 55 && chem >= 50)
            {
                if ( math + phy + chem >= 180 || math + phy >= 140 || math + chem >= 140 )
                {
                    Console.WriteLine("The candidate is eligible for admission");
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission");
                }
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadKey();
        }
    }
}
