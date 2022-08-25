namespace GradeBook.Model
{
  public class DiskBook : Book
  {
    public DiskBook(string name) : base(name)
    {
      Name = name;
    }

    public override event GradesAddDelegate GradesAdd;

    public override void AddGrades(double grades)
    {
      using (StreamWriter writter = File.AppendText($"{Name}.txt"))
      {
        writter.WriteLine(grades);
        if(GradesAdd != null) 
        {
          GradesAdd(this, new EventArgs());
        }
      }
    }

    public override Statistics ComputeStatistics()
    {
      Statistics result = new Statistics();

      using(var reader = File.OpenText($"{Name}.txt")) 
      {
        string? line = reader.ReadLine();  
        while(line != null)
        {
          double grades = double.Parse(line);
          result.Add(grades);
          line = reader.ReadLine();
        }
      }

      return result;
    }
  }
}