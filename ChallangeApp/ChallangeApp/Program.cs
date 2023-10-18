using ChallangeApp;

Employee employee1 = new Employee("Arek", "Zioło", 18);
Employee employee2 = new Employee("Monika", "Koslo", 24);
Employee employee3 = new Employee("Zuzia", "Tylko", 48);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(5);
//15

employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(1);
//31

employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(6);
//20

var result = employee1.Result;
Console.WriteLine(employee1.Name + " " + employee1.Surname + " zdobył/a " + result + " punktów, wiek " + employee1.Age);


var result1 = employee2.Result;
Console.WriteLine(employee2.Name + " " + employee2.Surname + " zdobył/a " + result1 + " punktów, wiek " + employee2.Age);


var result2 = employee3.Result;
Console.WriteLine(employee3.Name + " " + employee3.Surname + " zdobył/a " + result2 + " punktów, wiek " + employee3.Age);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee EmpolyeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        EmpolyeeWithMaxResult = employee;
    }
}
Console.WriteLine("");
Console.WriteLine(EmpolyeeWithMaxResult.Name + ", lat " + EmpolyeeWithMaxResult.Age + " zdobyła największą ilość punktów która wynosi: " + EmpolyeeWithMaxResult.Result);