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
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithForEach();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();


Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} otrzymał:");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Average: {statistics1.Average:N2}");
