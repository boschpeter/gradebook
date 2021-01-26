using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)

        { if (grade <= 100 && grade >=0 )
        //{ if (grade <= 100 || grade >=0 )
        // if (grade == 90.0)
        {

            grades.Add(grade);
        }  
        else 
        {
         throw new ArgumentException ($"Invalid {nameof(grade)}" );

        }
        }

        //public class Statistics
        // {
        //     public double Average;
        //     public double High;
        //     public double Low;
        //
        // }

        public Statistics GetStatistics()
        {

            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            

            foreach (var grade in grades)
            {

                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;

            }
            result.Average /= grades.Count;

            
             switch (result.Average)
                {
                  case var d when d >= 90.0:
                    result.letter = 'A';
                    break;
                    
                    case var d when d >= 80.0:
                    result.letter = 'B';
                    break;        case var d when d >= 70.0:
                    result.letter = 'C';
                    break;


                    case var d when d >= 60.0:
                    result.letter = 'D';
                    break;

                    default:
                     result.letter ='F';
                     break; 
 



                }




            return result;
            
            //           Console.WriteLine($"the lowest rate is {lowGrade}");
            //           Console.WriteLine($"the highest rate is {highGrade}");
            //           Console.WriteLine($"The average grade is {result:N3}");
        }

        static private List<double> grades;
        public string Name;

    }
}