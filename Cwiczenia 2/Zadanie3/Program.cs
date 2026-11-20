Console.WriteLine("Ile ocen chcesz wprowadzić? ");
int n = int.Parse(Console.ReadLine());

double sum = 0;
int max = 1;
int min = 6;
int p = 0;

for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Podaj ocene: ");
    int ocena = int.Parse(Console.ReadLine());

    sum += ocena;
    if (ocena > max)
    {
        max = ocena;
    }
    if (ocena < min)
    {
        min = ocena;
    }
    if (ocena >= 3)
    {
        p++;
    }
}
double srednia = sum / n;
Console.WriteLine("___________");
Console.WriteLine($"Srednia: {srednia:F2}");
Console.WriteLine($"Najwyzsza ocena: {max}");
Console.WriteLine($"Najnizsza ocena: {min}");
Console.WriteLine($"Liczba ocen pozytywnych: {p}");