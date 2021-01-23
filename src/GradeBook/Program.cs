using System;
using System.Collections.Generic;
//git clone git@github.com:boschpeter/gradebook.git

namespace GradeBook
{
    class Program
    {   
        static void Main(string[] args)
        {
           
         var book = new Book ();
         book.AddGrade(89.1);

          var grades = new List<double> () {12.7, 10.3, 6.11, 4.1} ;
          grades.Add(56.1); 
          var result =  0.0;
          var highGrade = double.MinValue;
          var lowGrade = double.MaxValue;

                foreach (var number in grades)
            {

                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;

            }
               
             //  result = result / grades.Count;‹
              result /= grades.Count;
            Console.WriteLine($"the lowest rate is {lowGrade}");
            Console.WriteLine($"the highest rate is {highGrade}");
             Console.WriteLine($"The average grade is {result:N3}");
        }
    }
}

