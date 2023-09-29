using System;

struct Student
{
    public string Name;
    public string GroupNumber;
    public int[] Grades;

    public double AverageGrade()
    {
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];

        students[0] = new Student { Name = "John Doe", GroupNumber = "Group A", Grades = new int[] { 5, 4, 5, 4, 4 } };
        students[1] = new Student { Name = "Alice Smith", GroupNumber = "Group B", Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[2] = new Student { Name = "Bob Johnson", GroupNumber = "Group A", Grades = new int[] { 4, 4, 3, 4, 5 } };
        students[3] = new Student { Name = "Emily Brown", GroupNumber = "Group C", Grades = new int[] { 3, 3, 3, 4, 2 } };
        students[4] = new Student { Name = "David Wilson", GroupNumber = "Group B", Grades = new int[] { 4, 5, 4, 3, 4 } };
        students[5] = new Student { Name = "Sophia Lee", GroupNumber = "Group A", Grades = new int[] { 4, 5, 4, 4, 5 } };
        students[6] = new Student { Name = "Oliver Davis", GroupNumber = "Group C", Grades = new int[] { 2, 2, 2, 3, 3 } };
        students[7] = new Student { Name = "Emma Martinez", GroupNumber = "Group B", Grades = new int[] { 5, 4, 5, 5, 5 } };
        students[8] = new Student { Name = "Liam Anderson", GroupNumber = "Group A", Grades = new int[] { 3, 4, 3, 3, 4 } };
        students[9] = new Student { Name = "Mia Johnson", GroupNumber = "Group C", Grades = new int[] { 5, 4, 5, 5, 4 } };

        Array.Sort(students, (x, y) => x.AverageGrade().CompareTo(y.AverageGrade()));

        Console.WriteLine("Students with grades 4 or 5:");
        foreach (Student student in students)
        {
            bool hasLowGrades = false;
            foreach (int grade in student.Grades)
            {
                if (grade < 4)
                {
                    hasLowGrades = true;
                    break;
                }
            }

            if (!hasLowGrades)
            {
                Console.WriteLine($"Name: {student.Name}, Group: {student.GroupNumber}");
            }
        }

        // Wait for Enter key press before exiting
        Console.ReadLine();
    }
}
