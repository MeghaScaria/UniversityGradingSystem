using UniversityGradingSystem.Models;

namespace UniversityGradingSystem.Services;

public class ResultService
{
    private readonly GradeCalculator _gradeCalculator  = new();


    public Result GenerateResult(Student student)
    {
        double totalMarks = _gradeCalculator.CalculateTotalMarks(student);

        double maximumMarks = _gradeCalculator.CalculateMaximumMarks(student);

        double percentage = _gradeCalculator.CalculatePercentage(student);

        var grade = _gradeCalculator.CalculateGrade(percentage);

        var status = _gradeCalculator.CalculateResult(percentage);

        string division = _gradeCalculator.CalculateDivision(percentage);

        string remark = _gradeCalculator.GenerateRemark(grade);

        return new Result
        {
            TotalMarks = totalMarks,
            MaximumMarks = maximumMarks,
            Percentage = percentage,
            Grade = grade,
            Status = status,
            Division = division,
            Remark = remark
        };
    }
}