namespace GradeBook.Model
{
  public class Book
  {

    List<double> Grades;
    string Name;

    public Book(string name)
    {
      Grades = new();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      Grades.Add(grade);
    }

    public Statistics ComputeStatistics()
    {
      Statistics statistics = new();
      statistics.Average = 0.0;
      statistics.High = double.MinValue;
      statistics.Low = double.MaxValue;

      foreach (var grade in Grades)
      {
        statistics.High = Math.Max(grade, statistics.High);
        statistics.Low = Math.Min(grade, statistics.Low);
        statistics.Average += grade;
      }
      statistics.Average /= Grades.Count;

      return statistics;
    }
  }
}