namespace Jagan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j;
            Console.WriteLine("Enter limit");
            int limit = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int i = 1; i <= limit; ++i)
            {
                for(j = 1; j <= i; ++j)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
