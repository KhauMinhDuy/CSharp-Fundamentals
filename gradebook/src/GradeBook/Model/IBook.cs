namespace GradeBook.Model
{
  public interface IBook
    {
      void AddGrades(double grades);
      Statistics ComputeStatistics();
      event GradesAddDelegate GradesAdd;
      public string Name { get; }
    }
}