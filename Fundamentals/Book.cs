using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Book
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
            this.Id = id;
            this.Name = name;
        }

        public List<double> Grades { get => grades; set => grades = value; }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public double findHigh()
        {
            double high = double.MinValue;
            foreach(double number in this.grades)
            {
                high = Math.Max(number, high);
            }
            return high;
        }

        public double findLow()
        {
            double low = double.MaxValue;
            foreach (double number in this.grades)
            {
                low = Math.Min(number, low);
            }
            return low;
        }

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
