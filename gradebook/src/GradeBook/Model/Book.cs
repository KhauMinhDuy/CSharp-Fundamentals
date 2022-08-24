namespace GradeBook.Model
{

  public delegate void GradesAddDelegate(object sender, EventArgs eventArgs);

  public class Book
  {

    public List<double> Grades;
    public string Name {get; set;}
    public event GradesAddDelegate GradesAdd;
    public const string CATEGORY = "asd";

    public Book(string name)
    {
      Grades = new();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      if (0 <= grade && grade < 100)
      {
        Grades.Add(grade);
        if(GradesAdd != null) 
        {
          GradesAdd(this, new EventArgs());
        }
      }
      else
      {
        throw new ArgumentException($"Invalid {nameof(grade)}");
      }
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

      switch(statistics.Average)
      {
        case var average when average >= 90:
          statistics.Letter = 'A';
          break;
        case var average when average >= 80:
          statistics.Letter = 'B';
          break;
        case var average when average >= 70:
          statistics.Letter = 'C';
          break;
        case var average when average >= 60:
          statistics.Letter = 'D';
          break;
        default:
          statistics.Letter = 'F';
          break;
      }

      return statistics;
    }

    public void AddGrade(char letter)
    {
      switch (letter)
      {
        case 'A':
          AddGrade(90);
          break;
        case 'B':
          AddGrade(80);
          break;
        case 'C':
          AddGrade(70);
          break;
        default:
          AddGrade(0);
          break;
      }
    }

  }

}