namespace GradeBook.Model
{

  public delegate void GradesAddDelegate(object sender, EventArgs eventArgs);

  public class InMemoryBook : Book
  {

    public List<double> Grades;
    public override event GradesAddDelegate GradesAdd;
    public const string CATEGORY = "asd";

    public InMemoryBook(string name) : base(name)
    {
      Grades = new List<double>();
      Name = name;
    }

    public override void AddGrades(double grade)
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

    public override Statistics ComputeStatistics()
    {
      Statistics statistics = new();

      foreach (var grade in Grades)
      {
        statistics.Add(grade);
      }

      return statistics;
    }

    public void AddGrades(char letter)
    {
      switch (letter)
      {
        case 'A':
          AddGrades(90);
          break;
        case 'B':
          AddGrades(80);
          break;
        case 'C':
          AddGrades(70);
          break;
        default:
          AddGrades(0);
          break;
      }
    }
   
  }

}