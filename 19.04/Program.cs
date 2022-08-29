// первое

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[Первое задание!]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Random rn = new Random();

int[] Array1 = new int[10];

for (int i = 0; i < 10; i++)
{
    Array1[i] = rn.Next(-10, 10);
}

for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(Array1[i] + " ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();

int plus = 0;

for (int i = 0; i < 10; i++)
{
    if (Array1[i] > 0)
    {
        plus++;
    }
}

Console.WriteLine("Положительных чисел в массиве --> " + plus);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[Второе задание!]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

// второе

int[] Array2 = new int[10];

for (int i = 0; i < 10; i++)
{
    Array2[i] = rn.Next(-10, 10);
}

for (int i = 0; i < 10; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(Array2[i] + " ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();

int min = int.MaxValue;

for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        if (Array2[i] >= 0)
        {
            if (min > Array2[i])
            {
                min = Array2[i];
            }
        }
    }
}

Console.WriteLine("Наименьший положительный элемент среди элементов с четными номерами массива: " + min);

// третье 

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[Третье задание!]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

int[,] list = new int[4, 4];

for (int i = 0;i < 4; i++)
{
    for (int j = 0;j < 4; j++)
    {
        list[i, j] = rn.Next(1, 15);
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(list[i, j] + "\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    for (int j = i; j < 4; j++)
    {
        list[i, j] = 0;
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(list[i, j] + "\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}
Console.WriteLine();

// четвертое 

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[Четвертое задание!]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

int[,] list2 = new int[3, 4];
double[] answer = new double[4];
double sum = 0;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        list2[i, j] = rn.Next(1, 15);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(list2[i, j] + "\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        sum += list2[j, i];
    }
    sum = sum / 3;
    answer[i] = sum;
    sum = 0;
}


for (int i = 0; i < 4; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"[{i}] " + answer[i]);
    Console.ForegroundColor = ConsoleColor.White;
}
