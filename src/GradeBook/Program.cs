using System;

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
            //  var  z = x + y;
            //  Console.WriteLine(z);
      

                var numbers  = new double[3] {12.7, 10.3, 6.11} ;
                //numbers[0] = 12.7;
                //numbers[1] = 10.3;
                //numbers[2] = 6.11;
               //
                var result =  numbers[0];
                result = result + numbers[1];
                result = result + numbers[2]; 

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

