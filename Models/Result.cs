using UniversityGradingSystem.Enums;

namespace UniversityGradingSystem.Models;

public class Result
{
    public double TotalMarks { get; set; }

    public double MaximumMarks { get; set; }

    public double Percentage { get; set; }

    public Grade Grade { get; set; }

    public ResultStatus Status { get; set; }

    public string Remark { get; set; } = string.Empty;

    public string Division { get; set; } = string.Empty;
}