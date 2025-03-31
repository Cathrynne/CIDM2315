using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9
{
    // Student class holds student ID and name
    class Student
    {
        private int studentID;
        private string studentName;

        // Shared list to keep track of all students
        public static List<Student> studentList = new List<Student>();

        // Constructor adds each new student to the list
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        // Prints basic info about the student
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID} | Name: {studentName}");
        }

        // Helper to get student name
        public string GetName()
        {
            return studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to the Student Gradebook ===\n");

            // Step 1: Create 4 students
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // Step 2: Create gradebook dictionary
            Dictionary<string, double> gradebook = new Dictionary<string, double>()
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

            // Step 3: Check for Tom, add him if not found
            if (!gradebook.ContainsKey("Tom"))
            {
                Console.WriteLine("Tom not found in gradebook. Adding Tom with GPA 3.3.\n");
                gradebook.Add("Tom", 3.3);
            }

            // Step 4: Calculate average GPA
            double totalGPA = gradebook.Values.Sum();
            double averageGPA = totalGPA / gradebook.Count;

            Console.WriteLine($"Average GPA of all students: {averageGPA:F2}\n");

            // Step 5: Show students with GPA above average
            Console.WriteLine("Students with GPA above average:\n");

            foreach (Student student in Student.studentList)
            {
                string name = student.GetName();
                if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
                {
                    student.PrintInfo();
                    Console.WriteLine($"GPA: {gradebook[name]:F2}\n");
                }
            }

            Console.WriteLine("=== End of Program ===");
        }
    }
}
