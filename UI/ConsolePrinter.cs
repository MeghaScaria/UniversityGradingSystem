using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.UI;

public class ConsolePrinter
{
    public void PrintResult(Student student, Result result)
    {
        Console.WriteLine();
        Console.WriteLine("========== STUDENT DETAILS ==========");

        Console.WriteLine($"Student ID   : {student.StudentId}");
        Console.WriteLine($"Student Name : {student.StudentName}");
        Console.WriteLine($"Course       : {student.CourseName}");

        Console.WriteLine();

        Console.WriteLine("========== SUBJECT MARKS ==========");

        foreach (var subject in student.Subjects)
        {
            Console.WriteLine(
                $"{subject.Name,-15} {subject.MarksObtained}/{subject.MaximumMarks}");
        }

        Console.WriteLine();

        Console.WriteLine("========== RESULT ==========");

        Console.WriteLine($"Total Marks     : {result.TotalMarks}");
        Console.WriteLine($"Maximum Marks   : {result.MaximumMarks}");
        Console.WriteLine($"Percentage      : {result.Percentage:F2}%");
        Console.WriteLine($"Grade           : {result.Grade}");
        Console.WriteLine($"Result          : {result.Status}");
        Console.WriteLine($"Division        : {result.Division}");
        Console.WriteLine($"Remark          : {result.Remark}");

        Console.WriteLine();
    }

    public void PrintError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void PrintSuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}