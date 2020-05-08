using System;

namespace WhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i < 33)
            {
                Console.WriteLine(i);
                i=i+5;
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
