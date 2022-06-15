double sum = 0, sr = 0;
int k = 0;

Random rnd = new Random();

Console.WriteLine("");
Console.WriteLine("[Start Program]");
Console.WriteLine("");

double[,] list = new double[3,4];
double[] list2 = new double[4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        list[i, j] = rnd.Next(0, 15);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{list[i, j]}\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine("");
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sum += list[j, i];
    }
    sr = Math.Round(sum / 3);
    list2[k] = sr;
    k++;
    sum = 0;
}

for (int i = 0; i < 4; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{list2[i]}\t");
    Console.ForegroundColor = ConsoleColor.White;
}


