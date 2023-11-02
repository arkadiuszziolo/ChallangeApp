using ChallangeApp;

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var supervisor = new Supervisor("Arek", "Zioło", 22, 'M');

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę DYREKTORA:");
    var input1 = Console.ReadLine();
    if (input1 == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input1);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics1 = supervisor.GetStatistics();
Console.WriteLine($"Person: {supervisor.Name} {supervisor.Surname} Gender: {supervisor.Gender} Age: {supervisor.Age}");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average Letter: {statistics1.AverageLetter}");
