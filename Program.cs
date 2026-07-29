// namespaces
using UniversityGradingSystem.Models;
using UniversityGradingSystem.Services;
using UniversityGradingSystem.UI;

//target-typed new expressions
Menu menu = new();
ConsolePrinter printer = new();

StudentInputService inputService = new();
ResultService resultService = new();

Student? currentStudent = null;
Result? currentResult = null;

bool running = true;

while (running)
{
    menu.DisplayMainMenu();

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            menu.DisplayStudentHeader();

            currentStudent = inputService.GetStudentDetails();

            currentResult = resultService.GenerateResult(currentStudent);

            menu.DisplayResultHeader();

            printer.PrintResult(currentStudent, currentResult);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            break;

        case "2":

            Console.Clear();

            if (currentStudent == null || currentResult == null)
            {
                printer.PrintError("No student result available.");
            }
            else
            {
                menu.DisplayResultHeader();

                printer.PrintResult(currentStudent, currentResult);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            break;

        case "3":

            currentStudent = null;
            currentResult = null;

            printer.PrintSuccess("Current data cleared successfully.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            break;

        case "4":

            running = false;

            menu.DisplayExitMessage();

            break;

        default:

            printer.PrintError("Invalid menu option.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            break;
    }
}