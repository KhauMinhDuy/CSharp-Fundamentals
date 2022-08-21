namespace GradeBook
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var x = 34.1;
      var y = 10.3;
      var result = x + y;
      Console.WriteLine($"Result: {result}");

      // var numbers = new double[3];
      // numbers[0] = 12.7;
      // numbers[1] = 10.3;
      // numbers[2] = 6.11;

      var numbers = new[] { 12.7, 10.3, 6.11 };
      var result2 = 0.0;
      foreach (var number in numbers)
      {
        result2 += number;
      }
      Console.WriteLine($"Result2: {result2}");

      var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
      grades.Add(56.1);

      var result3 = 0.0;
      foreach (var grade in grades)
      {
        result3 += grade;
      }
      Console.WriteLine($"Result3: {result3}");

      var result4 = result3 / grades.Count;
      Console.WriteLine($"The average grade is {result4:N1}");

      if (args.Length > 0)
      {
        Console.WriteLine($"Hello {args[0]}");
      }
      else
      {
        Console.WriteLine($"Hello Minh Duy");
      }
    }
  }
}