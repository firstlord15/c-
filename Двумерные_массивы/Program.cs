Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите кол-во строки: ");
Console.ForegroundColor = ConsoleColor.White;
int n = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Введите кол-во столбцы: ");
Console.ForegroundColor = ConsoleColor.White;
int x = Convert.ToInt32(Console.ReadLine());  

int[,] Array;
Array = new int[n, x];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < x; j++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write($"Введите элемент [{i}]-ого столбца {j} строки: ");
        Console.ForegroundColor = ConsoleColor.White;
        int el = Convert.ToInt32(Console.ReadLine());

        Array[i, j] = el;
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < x; j++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Array[i, j]} ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}

Console.WriteLine("");

// первое 

Console.Write("Введите число k: ");
int k = Convert.ToInt32(Console.ReadLine());
int sum = 1, chet = 0;



for (int i = 0; i < n; i++)
{
    for (int j = 0; j < x; j++)
    {
        if (Array[i, j] % k == 0)
        {
            chet++;
        }
    }
}

if (chet == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Таких значений нет");
    Console.ForegroundColor = ConsoleColor.White;
} 
else
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < x; j++)
        {
            if (Array[i, j] % k == 0)
            {
                sum *= Array[i, j];
            }
        }
    }

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Произведение чисел кратных {k} == {sum}");
    Console.ForegroundColor = ConsoleColor.White;
}


// доп задание 
int sum2 = 0;

int dopch = 0;
int[] dop = new int[n*x];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < x; j++)
    {
        if (Array[i,j] < 0)
        {
            dop[dopch] = i;
            dopch++;
        }
    }
}

Console.WriteLine(dopch);


for (int i = 0; i < n; i++)
{
    if (i == dop[i])
    {
        for(int j = 0; j < x; j++)
        {
            sum2 += Array[i, j];
        }
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Сумма чисел, где есть отриц. числа = {sum2}");
Console.ForegroundColor = ConsoleColor.White;