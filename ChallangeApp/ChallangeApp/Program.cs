int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int counterChar0 = 0;
int counterChar1 = 0;
int counterChar2 = 0;
int counterChar3 = 0;
int counterChar4 = 0;
int counterChar5 = 0;
int counterChar6 = 0;
int counterChar7 = 0;
int counterChar8 = 0;
int counterChar9 = 0;

foreach (char liczba in letters)
{
    if(liczba == '0')
    {
        counterChar0++;
    }
    else if(liczba == '1') 
    {
        counterChar1++;
    }
    else if (liczba == '2')
    {
        counterChar2++;
    }
    else if (liczba == '3')
    {
        counterChar3++;
    }
    else if (liczba == '4')
    {
        counterChar4++;
    }
    else if (liczba == '5')
    {
        counterChar5++;
    }
    else if (liczba == '6')
    {
        counterChar6++;
    }
    else if (liczba == '7')
    {
        counterChar7++;
    }
    else if (liczba == '8')
    {
        counterChar8++;
    }
    else if (liczba == '9')
    {
        counterChar9++;
    }
}

Console.WriteLine("Wynik wystąpień liczb dla liczby " + number +":");
Console.WriteLine("0 => " + counterChar0);
Console.WriteLine("1 => " + counterChar1);
Console.WriteLine("2 => " + counterChar2);
Console.WriteLine("3 => " + counterChar3);
Console.WriteLine("4 => " + counterChar4);
Console.WriteLine("5 => " + counterChar5);
Console.WriteLine("6 => " + counterChar6);
Console.WriteLine("7 => " + counterChar7);
Console.WriteLine("8 => " + counterChar8);
Console.WriteLine("9 => " + counterChar9);