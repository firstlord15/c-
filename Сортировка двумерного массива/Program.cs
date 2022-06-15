Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[n, m];

// команда для выводы 2-мерного массива
static void print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Запоняем двумерный массив
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = random.Next(0, 10);
    }
}

// Выводим его для видимости
Console.ForegroundColor = ConsoleColor.Cyan;
print(a);
Console.ForegroundColor = ConsoleColor.White;

// создаем одномерный массив
int[] arr = new int[n * m];
int col = 0;

// заполняем одномерный массив {arr} данными из 2-мерного массива {a}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[col] = a[i, j];
        col++;
    }
}

// Сортируем одномернный массив
int temp = 0;

for (int k = 0; k < n*m; k++)
{
    for (int i = 0; i < n * m; i++)
    {
        if (i != 0)
        {
            if (arr[i] < arr[i - 1])
            {
                temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }
        }
    }
}

// Переделываем одномерный массив обратно в двумерный
col = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = arr[col];
        col++;
    }
}
Console.WriteLine();

// Выводим результат
Console.ForegroundColor = ConsoleColor.Magenta;
print(a);
Console.ForegroundColor = ConsoleColor.White;