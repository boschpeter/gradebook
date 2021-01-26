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
         
         
         // book.AddGrade(89.1);
         // book.AddGrade(90.5);
         // book.AddGrade(77.4);
         // book.AddGrade(77.6);
    
//var done = false;
//           while (!done)
//           {
//            Console.WriteLine("Enter a grade or 'q' to quit ");   
//            var input = Console.ReadLine();
//            if (input == "q")
//            {
//               done = true;
//               continue;
//
//            }
//            var grade = double.Parse(input);
//           }
//           

            while (true)
           {
            Console.WriteLine("Enter a grade or 'q' to quit ");   
            var input = Console.ReadLine();
            if (input == "q")
            {
              break;
            }
            
            try
            {
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }

            catch ( ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }

            catch ( FormatException  ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                    System.Console.WriteLine("**");

            }

//            catch ( Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                throw;
//            }
            
            
           }               
           


            var stats = book.GetStatistics();
         
             Console.WriteLine($"the lowest rate is {stats.Low}");
             Console.WriteLine($"the highest rate is {stats.High}");
             Console.WriteLine($"The average grade is {stats.Average:N1}");
             Console.WriteLine($"the letter grade is {stats.letter} "); 

        }
    }
}
