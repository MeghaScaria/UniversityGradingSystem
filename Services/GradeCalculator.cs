using System.Linq;
using UniversityGradingSystem.Models;
using UniversityGradingSystem.Enums;
using UniversityGradingSystem.Constants;

namespace UniversityGradingSystem.Services;

public class GradeCalculator
{
    // Calculates total marks obtained
    public double CalculateTotalMarks(Student student)
    {
        return student.Subjects.Sum(subject => subject.MarksObtained);
    }

    // Calculates maximum possible marks
    public double CalculateMaximumMarks(Student student)
    {
        return student.Subjects.Sum(subject => subject.MaximumMarks);
    }

    // Calculates percentage
    public double CalculatePercentage(Student student)
    {
        double total = CalculateTotalMarks(student);
        double maximum = CalculateMaximumMarks(student);

        if (maximum == 0)
            return 0;

        return (total / maximum) * 100;
    }

    // Assigns Grade
    public Grade CalculateGrade(double percentage)
    {
        return percentage switch
        {
            >= 90 => Grade.A,
            >= 75 => Grade.B,
            >= 60 => Grade.C,
            >= 40 => Grade.D,
            _ => Grade.F
        };
    }

    // Pass or Fail
    public ResultStatus CalculateResult(double percentage)
    {
        return percentage >= GradeRules.Pass
            ? ResultStatus.Pass
            : ResultStatus.Fail;
    }

    // Class Division
    public string CalculateDivision(double percentage)
    {
        return percentage switch
        {
            >= GradeRules.Distinction => "Distinction",
            >= GradeRules.FirstClass => "First Class",
            >= GradeRules.SecondClass => "Second Class",
            >= GradeRules.Pass => "Pass Class",
            _ => "No Division"
        };
    }

    // Academic Remark
    public string GenerateRemark(Grade grade)
    {
        return grade switch
        {
            Grade.A => "Outstanding Performance!",
            Grade.B => "Excellent Work!",
            Grade.C => "Good Job!",
            Grade.D => "Needs Improvement.",
            Grade.F => "Failed. Better Luck Next Time.",
            _ => "No Remark"
        };
    }
}