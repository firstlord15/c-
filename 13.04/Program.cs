// 7 вариант

/*
 
Console.WriteLine("Hello, World!");
Console.WriteLine();
Random rn = new Random();

int n = 0, m = 0;

Console.Write("Введите кол-во столбцов: ");
Console.ForegroundColor = ConsoleColor.Green;
n = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

Console.Write("Введите кол-во строк: ");
Console.ForegroundColor = ConsoleColor.Green;
m = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

int[,] list = new int[n, m];
int[,] list2 = new int[n+1, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        list[i,j] = rn.Next(1, 25);
    }
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(list[i, j] + "\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.Write("Введите число: ");
Console.ForegroundColor = ConsoleColor.Green;
int A = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;

int temp = -1;
bool h = false;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (list[i,j] == A)
        {
            temp = i;
            h = true;
            break;
        }
    }
    if (h)
        break;
}

if (temp != -1)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i >= temp)
            {
                list2[i + 1, j] = list[i, j];
            }
            else
            {
                list2[i, j] = list[i, j];
            }
        }
    }

    Console.WriteLine();
    
    for (int i = 0; i < n + 1; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(list2[i, j] + "\t");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine();
    }

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Такого числа нет в списке!");
    Console.ForegroundColor = ConsoleColor.White;
}
 
 */

// 14 вариант

int[,] Array = new int[5, 5];

Random rn = new Random();

for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        Array[i, j] = rn.Next(-15, 15);
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(Array[i, j] + " ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[Выполнения задания...]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

int min = Array[0,0];
int inmin = 0;

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if (Array[i, j] < min)
        {
            min = Array[i, j];
            inmin = i;
        }
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine();
Console.WriteLine(min);
Console.ForegroundColor = ConsoleColor.White;

int[] list2 = new int[5];
int[,] Array2 = new int[6, 5];

for (int i = 0; i < 5; ++i)
{
    list2[i] = Array[1, i];
}

for (int i = 0; i < 5; ++i)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(list2[i] + " ");
    Console.ForegroundColor = ConsoleColor.White;
}

for (int i = 0; i < 5; ++i)
{
    Array[1, i] = 0;
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i-1 < inmin)
        {
            Array2[i, j] = Array[i, j];
        } 
        else if (i - 1 >= inmin)
        {
            Array2[i+1, j] = Array[i, j];
        }
    }
}

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Array2[i, j] + " ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 5; ++i)
{
    Array[inmin-1, i] = list2[i];
}