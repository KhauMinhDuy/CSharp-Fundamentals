using GradeBook.Model;

namespace GradeBook
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Book book = new Book("book1");

      while (true)
      {
        Console.Write("Nhap diem hoac nhap 'ngu nhu con bo' de thoat: ");
        var input = Console.ReadLine();
        if (input == "ngu nhu con bo") break;

        try
        {
          double grades = double.Parse(input);
          book.AddGrade(grades);
        }
        catch (ArgumentException e)
        {
          Console.WriteLine(e.Message);
        }
        catch(FormatException e) 
        {
          Console.WriteLine(e.Message);
        }
        finally
        {
          Console.WriteLine("***");
        }

      }

      Statistics statistics = book.ComputeStatistics();

      Console.WriteLine($"The lowest grade is {statistics.Low}");
      Console.WriteLine($"The highest grade is {statistics.High}");
      Console.WriteLine($"The average grade is {statistics.Average:N1}");
      Console.WriteLine($"The letter grades is {statistics.Letter}");
    }
  }
}