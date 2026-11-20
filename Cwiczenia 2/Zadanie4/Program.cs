Console.WriteLine("Podaj liczbe: ");
int n = int.Parse(Console.ReadLine());

int parzyste = 0;
int nieparzyste = 0;

Console.Write("Liczby parzyste: ");
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        parzyste++;
    }
    else
    {
        nieparzyste++;
    }
}
Console.WriteLine();
Console.WriteLine($"Ilość liczb parzystych: {parzyste}");
Console.WriteLine($"Ilość liczb nieparzystych: {nieparzyste}");
