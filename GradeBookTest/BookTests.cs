using System;
using Xunit;
using Fundamentals;

namespace GradeBookTest
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            int x = 5;
            int y = 2;
            int expected = 10;

            int actual = x * y;
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test2()
        {
            Book book = new Book();
            book.Id = 1;
            book.Name = "Khau Minh Duy";
            book.addGrade(1.1);
            book.addGrade(2.2);
            book.addGrade(3.3);
            book.addGrade(4.4);

            double high = book.findHigh();
            double low = book.findLow();

            Assert.Equal("Khau Minh Duy", book.Name);
            Assert.Equal(4.4, high);
            Assert.Equal(1.1, low);
        }
    }
}
