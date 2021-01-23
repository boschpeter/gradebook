using System;
//git clone git@github.com:boschpeter/gradebook.git
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {

            //  double x = 6.7 ;
            //  double y = 7.7 ;
            //  var
                var numbers  = new double[] {12.7, 10.3, 6.1} ;
               //
                var result =  numbers[0];
                result += numbers[1];
                result += numbers[2];
                result += numbers[3];

                Console.WriteLine(result);

                Console.WriteLine($"Hello {args[0]} nice to see you again");
             

            }
            else
            {
                Console.WriteLine("helleu");
            }
        }
    }
}

