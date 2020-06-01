using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book 
    {
        // This is a constructor method, access modifiers
        public Book(string name)
        {
            grades = new List<double>();
            // "this" is an implicit variable
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades) 
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }

        //by add the "public" to the List we grant access. While adding "private" we grant only access within the class
        private List<double> grades;
        public string Name;

    }
}