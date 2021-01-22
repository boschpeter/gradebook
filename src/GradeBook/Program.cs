using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
            Console.WriteLine($"Hello {args[0]} nice to see you again");
            }
            else {
                Console.WriteLine ("helleu");
            }
        }
    }
}
