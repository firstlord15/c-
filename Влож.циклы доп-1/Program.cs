string? N;
int n = 0, t = 1;

Console.Write("Введите N: ");
N = Console.ReadLine();

n = Convert.ToInt32(N);

for (int i = 2; i < n; i++)
{
    t = t * i;
    Console.WriteLine($"t2 = {t}");
}
