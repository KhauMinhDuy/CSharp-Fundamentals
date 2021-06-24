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
        }
    }
}
