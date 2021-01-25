using System;
using Xunit;

namespace GradeBook.test
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        {   //triple a for a proper abstraction
            //arrange  control-period
            //seperate deciding from doing =seperate responsibilities. 
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
          
            //act
            var result = ShowStatistics();
            
            // assert
            Assert.Equal(85.6, result.Average);
         
    }
}
