using System;
using System.Collections.Generic;
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
               // var numbers  = new [] {12.7, 10.3, 6.1} ;
               // List <double> grades = new List<double> ();  // control .
                var grades = new List<double> () {12.7, 10.3, 6.1} ;
               // grades.Add(56.1)

                var result =  0.0; 
                foreach (var number in grades)
            {

                result += number;

            }
               
             //  result = result / grades.Count;‹
              result /= grades.Count;


             Console.WriteLine($"The average grade is {result:N3}");

               Console.WriteLine($"Hello {args[0]} nice to see you again");
             

            }
            else
            {
                Console.WriteLine("helleu");
            }
        }
    }
}

