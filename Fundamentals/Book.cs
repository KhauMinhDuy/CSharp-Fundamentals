using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    class Book
    {
        private int id;
        private string name;
        private List<double> grades;

        public Book()
        {
            this.grades = new List<double>();
        }

        public Book(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public List<double> Grades { get => grades; set => grades = value; }

        public void addGrade(double v)
        {
            this.grades.Add(v);
        }

        public static void methodStatic()
        {
            Console.WriteLine("Static Method");
        }

        public void showInfo()
        {
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            foreach (double number in this.grades)
            {
                //if(number > highGrade)
                //{
                //    highGrade = number;
                //}
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
            }
            Console.WriteLine($"High Grade: {highGrade}");
            Console.WriteLine($"Lowest Grade: {lowGrade}");
        }
    }
}
