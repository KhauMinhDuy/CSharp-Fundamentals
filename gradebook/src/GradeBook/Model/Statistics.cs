namespace GradeBook.Model
{
  public class Statistics
  {
    public double Average
    {
      get
      {
        return Sum / Count;
      }
      set
      {
        
      }
    }
    public double High { get; set; }
    public double Low { get; set; }
    public char Letter
    {
      get
      {
        switch (Average)
        {
          case var average when average >= 90:
            return 'A';
          case var average when average >= 80:
            return 'B';
          case var average when average >= 70:
            return 'C';
          case var average when average >= 60:
            return 'D';
          default:
            return 'F';
        }
      }
    }
    public double Sum { get; set; }
    public int Count { get; set; }

    public Statistics()
    {
      Average = 0.0;
      Sum = 0.0;
      Count = 0;
      High = double.MinValue;
      Low = double.MaxValue;
    }

    public void Add(double grade)
    {
      Sum += grade;
      Count++;
      High = Math.Max(grade, High);
      Low = Math.Min(grade, Low);
    }

  }
}