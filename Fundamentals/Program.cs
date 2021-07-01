using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {

            char c = 'c';
            //Console.WriteLine("Char: " + c);
            Console.WriteLine($"Char: {c}");

            string s = "Khau Minh Duy";
            //Console.WriteLine(s);
            Console.WriteLine($"string: {s}");

            bool b = true;
            //Console.WriteLine(b);
            Console.WriteLine($"Boolean: {b}");

            byte byteType = 10;
            //Console.WriteLine(byteType);
            Console.WriteLine($"Byte: {byteType}");

            short shortType = 100;
            Console.WriteLine($"Short: {shortType}");

            int intType = 1000;
            Console.WriteLine($"Int: {intType}");

            long longType = 10000;
            Console.WriteLine($"Long: {longType}");

            int x = 10;
            int y = 20;
            int result = x + y;
            Console.WriteLine($"Result: {result}");


            int[] numberInts = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            double[] numbers = new double[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }


            List<int> numbersInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Length numbersInt: {numbersInt.Count}");
            List<double> doubles = new List<double>();
            doubles.Add(1.1);
            doubles.Add(2.2);
            doubles.Add(3.3);
            doubles.Add(4.4);
            foreach (double number in doubles)
            {
                Console.WriteLine($"{number}");
            }

            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            foreach (double number in doubles)
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


            Book book = new Book();
            book.addGrade(8.9);
            book.addGrade(7.9);
            book.addGrade(6.9);
            book.addGrade(5.9);
            List<double> grades = book.Grades; // getter
            Console.WriteLine($"List: {grades[0]}");
            Book.methodStatic();

            book.showInfo();

            book.Name2 = "Khau Minh Duy";
            string name2 = book.Name2;

            Console.WriteLine(name2);

        }
    }
}
