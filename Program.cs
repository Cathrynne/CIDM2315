namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two professors with their names, subjects, and salaries
            Professor alice = new Professor("Alice", "Java", 9000);
            Professor bob = new Professor("Bob", "Math", 8000);

            // Creating two students with their names, enrolled courses, and grades
            Student lisa = new Student("Lisa", "Java", 90);
            Student tom = new Student("Tom", "Math", 80);

            // Displaying professor details
            Console.WriteLine($"Professor {alice.Name} teaches {alice.Subject}, and the salary is: ${alice.GetSalary()}.");
            Console.WriteLine($"Professor {bob.Name} teaches {bob.Subject}, and the salary is: ${bob.GetSalary()}.");

            // Displaying student details
            Console.WriteLine($"Student {lisa.Name} is enrolled in {lisa.Course} and has a grade of {lisa.GetGrade()}.");
            Console.WriteLine($"Student {tom.Name} is enrolled in {tom.Course} and has a grade of {tom.GetGrade()}.");

            // Calculating and displaying the salary difference
            double salaryDifference = alice.GetSalary() - bob.GetSalary();
            Console.WriteLine($"The salary difference between {alice.Name} and {bob.Name} is: ${salaryDifference}.");

            // Calculating and displaying the total grade of both students
            double totalGrade = lisa.GetGrade() + tom.GetGrade();
            Console.WriteLine($"The total grade of {lisa.Name} and {tom.Name} is: {totalGrade}.");
        }
    }

    class Professor
    {
        private string name;
        private string subject;
        private double salary;

        // Constructor to initialize a professor's details
        public Professor(string name, string subject, double salary)
        {
            this.name = name;
            this.subject = subject;
            this.salary = salary;
        }

        // Properties for name and subject
        public string Name { get { return name; } }
        public string Subject { get { return subject; } }

        // Methods to manage salary
        public void SetSalary(double newSalary)
        {
            salary = newSalary;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Student
    {
        private string name;
        private string course;
        private double grade;

        // Constructor to initialize a student's details
        public Student(string name, string course, double grade)
        {
            this.name = name;
            this.course = course;
            this.grade = grade;
        }

        // Properties for name and enrolled course
        public string Name { get { return name; } }
        public string Course { get { return course; } }

        // Methods to manage grades
        public void SetGrade(double newGrade)
        {
            grade = newGrade;
        }

        public double GetGrade()
        {
            return grade;
        }
    }
}
