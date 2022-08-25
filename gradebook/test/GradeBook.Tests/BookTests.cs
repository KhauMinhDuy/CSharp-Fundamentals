using GradeBook.Model;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTests
  {
    [Fact]
    public void BookCalculatesAnAverageGrades()
    {
      var book = new InMemoryBook("book");
      Assert.NotNull(book);

      book.AddGrades(89.1);
      book.AddGrades(90.5);
      book.AddGrades(77.3);
      var result = book.ComputeStatistics();

      Assert.Equal(85.6, result.Average, 1);
      Assert.Equal(77.3, result.Low);
      Assert.Equal(90.5, result.High);
      Assert.Equal('B', result.Letter);
    }
  }
}