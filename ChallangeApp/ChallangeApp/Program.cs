var name = "Ewa";
char gender = 'k';
var age = 33;

if (age < 30 && gender == 'k')
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else if (!(age > 32) && gender == 'k' && name == "Ewa")
{
    Console.WriteLine("Ewa nie ma powyżej 32 lat");
}
else if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Żaden warunek nie został spełniony");
}