using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] //this is an attribute which attaches to the symbol it follows it, in this case Test1()
        public void BookCalculatesAnAverageGrade()
        {
            // arrange section
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);


            // act section
            var result = book.GetStatistics();


            // assert section
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
