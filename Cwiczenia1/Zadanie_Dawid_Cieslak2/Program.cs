Random liczba = new Random();
int num = liczba.Next(1, 100);
Console.WriteLine("Zgadnij liczbę od 1 do 100:");
int liczba1 = int.Parse(Console.ReadLine());
while (liczba1 != num)
{
    if (liczba1 > num)
    {
        Console.WriteLine("ZA DUŻO!");
    }
    else
    {
        Console.WriteLine("ZA MAŁO!");
    }
    Console.WriteLine("Zgadnij liczbę od 1 do 100:");
    liczba1 = int.Parse(Console.ReadLine());
}
Console.WriteLine("Brawo zgadłeś!");