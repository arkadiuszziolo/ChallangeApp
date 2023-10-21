using ChallangeApp;

var employee = new Employee("Arek", "Zioło");
employee.AddGrade(10);
employee.AddGrade(200);
employee.AddGrade("20");
employee.AddGrade("Arek");
employee.AddGrade(5.11F);
employee.AddGrade(21123.15F);
employee.AddGrade(10.15);
employee.AddGrade(201.21);
employee.AddGrade(9223372036854775806);
//long
var statistics = employee.GetStatistics();



Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} otrzymał:");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
