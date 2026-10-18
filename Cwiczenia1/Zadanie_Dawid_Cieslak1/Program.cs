Console.WriteLine("Podaj imię?");
string name = Console.ReadLine();
    
Console.WriteLine("Podaj pierwszą ocenę?");
int firstrate = int.Parse(Console.ReadLine());
    
Console.WriteLine("Podaj drugą ocenę?");
int secondrate = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj trzecią ocenę?");
int thirdrate = int.Parse(Console.ReadLine());

double sum = (firstrate + secondrate + thirdrate);
double srednia = sum / 3;


Console.WriteLine(name+ $",Twoja średnia ocen to: {srednia:F2}");
double minrate = 3.0;
double maxrate = 6.0;
if (minrate >= srednia)
{
    Console.WriteLine("Nie Zaliczone!");
}
else
{
    Console.WriteLine("Zaliczone!");
}