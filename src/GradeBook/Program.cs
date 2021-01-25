using System;
using System.Collections.Generic;
//git clone git@github.com:boschpeter/gradebook.git

namespace GradeBook
{
    class Program
    {   
        static void Main(string[] args)
        {
           
         var book = new Book ("Scotts grade book");
         book.AddGrade(89.1);
         book.AddGrade(90.5);
         book.AddGrade(77.4);
         book.AddGrade(77.6);

            var stats = book.GetStatistics();
         
             Console.WriteLine($"the lowest rate is {stats.Low}");
             Console.WriteLine($"the highest rate is {stats.High}");
             Console.WriteLine($"The average grade is {stats.Average:N1}");


        }
    }
}
