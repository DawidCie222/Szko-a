Console.WriteLine("Podaj liczbę: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}