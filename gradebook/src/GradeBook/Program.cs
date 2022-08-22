using GradeBook.Model;

namespace GradeBook
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Book book = new Book("book1");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.5);
      Statistics statistics = book.ComputeStatistics();

      Console.WriteLine($"The lowest grade is {statistics.Low}");
      Console.WriteLine($"The highest grade is {statistics.High}");
      Console.WriteLine($"The average grade is {statistics.Average:N1}");
    }
  }
}