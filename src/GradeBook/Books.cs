using System.Collections.Generic;
using System;

namespace GradeBook
{
 public class Book {

     public Book (string name )
     {
      grades = new List<double> ();
      this.name = name;
     }

     public void AddGrade (double grade)

     { 
        grades.Add(grade);
     }

     public void ShowStatistics()
     {

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
    
    static private List<double> grades;
    private string name;

 }
}
