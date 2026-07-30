# 🎓 University Grading System

A C# .NET console application that manages student academic records, validates user input, calculates grades, and generates a detailed result report.

This project was developed as part of my internship assignment to practice object-oriented programming, clean code principles, and layered application architecture.

---

## 📌 Features

- Add student details
- Enter marks for 5 subjects
- Input validation for:
  - Student ID
  - Student Name
  - Course Name
  - Maximum Marks
  - Marks Obtained
- Automatic calculation of:
  - Total Marks
  - Percentage
  - Grade
  - Pass/Fail Status
- Display previously generated results
- Clear current student data
- Console messages with colored output for better readability

---

## 🏗️ Project Structure

```
UniversityGradingSystem
│
├── Constants
│   └── GradeRules.cs
│
├── Enums
│   ├── Grade.cs
│   └── ResultStatus.cs
│
├── Models
│   ├── Student.cs
│   ├── Subject.cs
│   └── Result.cs
│
├── Services
│   ├── StudentInputService.cs
│   ├── ResultService.cs
│   ├── GradeCalculator.cs
│   └── InputValidator.cs
│
├── UI
│   ├── Menu.cs
│   └── ConsolePrinter.cs
│
└── Program.cs
```

---

## 💡 Concepts Used

### Object-Oriented Programming (OOP)

- Classes and Objects
- Constructors
- Encapsulation
- Properties
- Composition

### C# Features

- Generic Collections (`List<T>`)
- Enums
- Nullable Reference Types
- Switch Expressions
- Target-Typed `new`
- Auto-Implemented Properties
- Lambda Expressions (LINQ)
- XML Documentation Comments

### Design Principles

- Separation of Concerns
- Layered Architecture
- Single Responsibility Principle (SRP)
- Manual Constructor Dependency Injection

---

## 🔄 Dependency Injection

The project uses **manual constructor dependency injection** for service dependencies.

Instead of creating dependencies inside a class:

```csharp
private readonly InputValidator _validator = new();
```

Dependencies are supplied externally:

```csharp
private readonly InputValidator _validator;

public StudentInputService(InputValidator validator)
{
    _validator = validator;
}
```

This separates object creation from business logic and makes the code more maintainable and easier to extend.

---

## ▶️ Menu Options

```
1. Add Student Details
2. View Current Result
3. Clear Current Data
4. Exit
```

---

## 🚀 How to Run

### Requirements

- .NET SDK 8.0 (or compatible version)
- Visual Studio 2022

### Run

```bash
dotnet run
```

or simply press **F5** in Visual Studio.
---

## Output

<details>
<summary><b>Test Case 1 - Choosing invalid options before entering information first</b></summary>

<br>

<img src="https://github.com/user-attachments/assets/95b506a7-eb10-490c-9ec0-0ef4e71a6e66" width="500"/>
<img src="https://github.com/user-attachments/assets/0bb57179-1d8d-4e14-8aa6-72b586526ec8" width="500"/>
<img src="https://github.com/user-attachments/assets/74741ef9-c69c-4779-baf8-d8f2cefce590" width="500"/>

</details>

<details>
<summary><b>Test Case 2 - Invalid Input Validation</b></summary>

<br>

<img src="https://github.com/user-attachments/assets/4765cc9c-3a74-412a-ab10-67212c90df15" width="500"/>

</details>

<details>
<summary><b>Test Case 3 - Successful Results Summary Calculation</b></summary>

<br>

<img src="https://github.com/user-attachments/assets/9da42c64-f173-47d8-857b-ea36d2d3c8c2" width="500"/>
<img src="https://github.com/user-attachments/assets/2ffd6ebd-ba46-4bf9-8197-aadad665e185" width="500"/>

</details>

---

## 📷 Sample Flow

```
Enter Student ID
↓

Enter Student Details
↓

Enter Subject Marks
↓

Generate Result
↓

Display Grade & Status
```

---

## 📚 Learning Outcomes

Through this project I gained hands-on experience with:

- Building layered console applications
- Applying object-oriented programming principles
- Designing reusable service classes
- Using collections and generics
- Implementing manual dependency injection
- Working with Git feature branches and merge workflows
- Writing clean, maintainable C# code

---

## 👨‍💻 Author

**Megha S**
