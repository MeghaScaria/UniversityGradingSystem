using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Services;

public class StudentInputService
{
    public InputValidator _validator = new();

    public Student GetStudentDetails()
    {
        Student student = new();

        Console.Write("Enter Student ID: ");

        while (true)
        {
            string? input = Console.ReadLine();

            if (_validator.IsValidStudentId(input))
            {
                student.StudentId = input!;
                break;
            }

            Console.Write("Invalid Student ID. Try again: ");
        }

        Console.Write("Enter Student Name: ");

        while (true)
        {
            string? input = Console.ReadLine();

            if (_validator.IsValidName(input))
            {
                student.StudentName = input!;
                break;
            }

            Console.Write("Invalid Name. Try again: ");
        }

        Console.Write("Enter Course Name: ");

        while (true)
        {
            string? input = Console.ReadLine();

            if (_validator.IsValidCourseName(input))
            {
                student.CourseName = input!;
                break;
            }

            Console.Write("Invalid Course Name. Try again: ");
        }

        Console.WriteLine();

        for (int i = 1; i <= 5; i++)
        {
            Subject subject = new();

            Console.Write($"Enter Subject {i} Name: ");
            subject.Name = Console.ReadLine() ?? "";

            while (true)
            {
                Console.Write($"Maximum Marks for {subject.Name}: ");

                if (double.TryParse(Console.ReadLine(), out double maxMarks)
                    && _validator.IsValidMaximumMarks(maxMarks))
                {
                    subject.MaximumMarks = maxMarks;
                    break;
                }

                Console.WriteLine("Invalid Maximum Marks.");
            }

            while (true)
            {
                Console.Write($"Marks Obtained in {subject.Name}: ");

                if (double.TryParse(Console.ReadLine(), out double marks)
                    && _validator.IsValidMarks(marks, subject.MaximumMarks))
                {
                    subject.MarksObtained = marks;
                    break;
                }

                Console.WriteLine("Invalid Marks.");
            }

            student.Subjects.Add(subject);

            Console.WriteLine();
        }

        return student;
    }
}