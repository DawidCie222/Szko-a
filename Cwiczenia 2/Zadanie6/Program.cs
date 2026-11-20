Console.WriteLine("Podaj liczbe: ");
int n = int.Parse(Console.ReadLine());

bool pierwsza = true;

if (n <= 1)
{
    pierwsza = false;
}
else
{
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            pierwsza = false;
            break;
        }
    }
}
if (pierwsza)
{
    Console.WriteLine($"{n} jest liczba pierwszą.");
}
else
{
    Console.WriteLine($"{n} nie jest liczba pierwszą.");
}