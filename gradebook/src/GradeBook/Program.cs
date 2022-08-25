using GradeBook.Model;

namespace GradeBook
{
  public class Program
  {

    public static void Main(string[] args)
    {
      IBook book = new DiskBook("book1");
      book.GradesAdd += OnGradesAdd;
      book.GradesAdd += OnGradesAdd;
      book.GradesAdd -= OnGradesAdd;

      EnterGrades(book);

      Statistics statistics = book.ComputeStatistics();

      Console.WriteLine($"The Book Name is {book.Name}");
      Console.WriteLine($"The lowest grade is {statistics.Low}");
      Console.WriteLine($"The highest grade is {statistics.High}");
      Console.WriteLine($"The average grade is {statistics.Average:N1}");
      Console.WriteLine($"The letter grades is {statistics.Letter}");
    }

    static void OnGradesAdd(object sender, EventArgs eventArgs)
    {
      Console.WriteLine($"a grades was add");
    }

    private static void EnterGrades(IBook book)
    {
      while (true)
      {
        Console.Write("Nhap diem hoac nhap 'ngu nhu con bo' de thoat: ");
        var input = Console.ReadLine();
        if (input == "q") break;

        try
        {
          double grades;
          double.TryParse(input, out grades);
          book.AddGrades(grades);
        }
        catch (ArgumentException e)
        {
          Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
          Console.WriteLine(e.Message);
        }
        finally
        {
          Console.WriteLine("***");
        }

      }
    }

  }
}