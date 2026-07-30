namespace UniversityGradingSystem.UI;

public class MenuView
{
    public void DisplayMainMenu()
    {
        Console.Clear();

        Console.WriteLine("==========================================");
        Console.WriteLine("      UNIVERSITY GRADING SYSTEM");
        Console.WriteLine("==========================================");
        Console.WriteLine();
        Console.WriteLine("1. Generate Student Result");
        Console.WriteLine("2. View Result Summary");
        Console.WriteLine("3. Clear Current Data");
        Console.WriteLine("4. Exit");
        Console.WriteLine();
        Console.Write("Enter your choice: ");
    }

    public void DisplayStudentHeader()
    {
        Console.Clear();

        Console.WriteLine("==========================================");
        Console.WriteLine("      STUDENT INFORMATION");
        Console.WriteLine("==========================================");
    }

    public void DisplayResultHeader()
    {
        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine("         RESULT SUMMARY");
        Console.WriteLine("==========================================");
    }

    public void DisplayExitMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Thank you for using University Grading System.");
    }
}