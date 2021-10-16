using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Random messi = new Random();
            Console.Write("-");
            for(int i = 0; i<1984; i++)
            {
                B:
                a = messi.Next(0, 9);
                if (i == 0 && a == 0) goto B;
                Console.Write(a);
            }
            Console.Write(" SOCIAL CREDIT!");
            Console.ReadKey();
        }
    }
}
