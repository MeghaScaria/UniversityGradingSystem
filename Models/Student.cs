using System.Collections.Generic;

namespace UniversityGradingSystem.Models;

public class Student
{
    public string StudentId { get; set; } = string.Empty;

    public string StudentName { get; set; } = string.Empty;

    public string CourseName { get; set; } = string.Empty;

    public List<Subject> Subjects { get; set; } = new();
}