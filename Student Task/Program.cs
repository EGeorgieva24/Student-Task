using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Students> studentList = new List<Students>();

        // Create instances of the Students class
        studentList.Add(new Students("Sashko", "A", 85));
        studentList.Add(new Students("Lily", "B", 62));
        studentList.Add(new Students("Garry", "A", 75));
        studentList.Add(new Students("Bob", "B", 42));
        studentList.Add(new Students("Steve", "A", 95));

        // Calculate average grade
        double averageGrade = Students.CalculateAverageGrade(studentList);

        // Sort students by name and display information
        var sortedStudents = studentList.OrderBy(s => s.Name);

        foreach (var student in sortedStudents)
        {
            string gradeCategory = Students.DetermineGradeCategory(student.FinalGrade);
            Console.WriteLine("Hello, my name is " + student.Name + ". I am a student in section " + student.Section + ", and my final grade is " + student.FinalGrade + ".");
        }

        Console.WriteLine("Average Grade for the class: " + averageGrade);
    }

    public class Students
    {
        public string Name;
        public string Section;
        public int FinalGrade;

        public Students(string name, string section, int finalGrade)
        {
            Name = name;
            Section = section;
            FinalGrade = finalGrade;
        }

        public Students(string name, string section)
        {
            Name = name;
            Section = section;
        }

        public static string DetermineGradeCategory(int finalGrade)
        {
            if (finalGrade >= 0 && finalGrade <= 35)
            {
                return "Poor";
            }
            else if (finalGrade >= 36 && finalGrade <= 50)
            {
                return "Satisfactory";
            }
            else if (finalGrade >= 51 && finalGrade <= 70)
            {
                return "Good";
            }
            else if (finalGrade >= 71 && finalGrade <= 85)
            {
                return "Very Good";
            }
            else if (finalGrade >= 86 && finalGrade <= 95)
            {
                return "Excellent";
            }
            else if (finalGrade >= 96 && finalGrade <= 100)
            {
                return "Exceed Expectations";
            }
            else
            {
                return "Invalid Grade";
            }
        }

        public static double CalculateAverageGrade(List<Students> students)
        {
            if (students.Count == 0)
            {
                return 0.0;
            }

            int totalGrades = students.Sum(s => s.FinalGrade);
            return (double)totalGrades / students.Count;
        }
    }
}
