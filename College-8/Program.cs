Console.WriteLine("Введите E: ");
double E = Convert.ToDouble(Console.ReadLine());

double S1 = 0;
double S = E;

double n = 1;
double d = 3;

while (Math.Abs(S1 - S) >= E)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Порядок = {n + 2} / {n + d}");
    double result = (n + 2) / (n + d);
    Console.ForegroundColor = ConsoleColor.White;

    d += 2 * n + 2;
    n++;

    S = S1;
    S1 += result;
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"result = {result}");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Сумма = {S}");
Console.ForegroundColor = ConsoleColor.White;


