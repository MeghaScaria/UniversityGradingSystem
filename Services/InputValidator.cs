namespace UniversityGradingSystem.Services;

public class InputValidator
{
    public bool IsValidName(string? name)
    {
        return !string.IsNullOrWhiteSpace(name);
    }

    public bool IsValidStudentId(string? studentId)
    {
        return !string.IsNullOrWhiteSpace(studentId);
    }

    public bool IsValidCourseName(string? courseName)
    {
        return !string.IsNullOrWhiteSpace(courseName);
    }

    public bool IsValidMaximumMarks(double maxMarks)
    {
        return maxMarks > 0;
    }

    public bool IsValidMarks(double marks, double maxMarks)
    {
        return marks >= 0 && marks <= maxMarks;
    }
}