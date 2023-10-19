using ChallangeApp;

var employee = new Employee("Arek", "Zioło");
employee.AddGrade(15.1F);
employee.AddGrade(5.5F);
employee.AddGrade(21.1F);
employee.AddGrade(7.1F);
var statistics = employee.GetStatistics();
Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} otrzymał:");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average:N2}");
