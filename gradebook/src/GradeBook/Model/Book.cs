using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeBook.Model
{
  public abstract class Book : NameObject, IBook
  {
    protected Book(string name) : base(name)
    {
    }

    public abstract event GradesAddDelegate GradesAdd;

    public abstract void AddGrades(double grades);

    public abstract Statistics ComputeStatistics();

  }
}