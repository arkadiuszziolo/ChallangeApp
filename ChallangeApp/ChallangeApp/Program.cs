using ChallangeApp;

Console.WriteLine("Welcome to XYZ's mployee evaluation program");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Arek", "Zioło", 22, 'M');
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Successfully added grade");
}

while (true)
{
    Console.WriteLine("Enter next employee evaluation:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Person: {employee.Name} {employee.Surname} Gender: {employee.Gender} Age: {employee.Age}");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
