Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] list = new int[n];

static int[] Create(int[] s, int x)
{
    for (int i = 0; i < x; i++)
    {
        Console.Write($"Введите [{i+1}] элемент: ");
        s[i] = Convert.ToInt32(Console.ReadLine());
    }

    return s;
}

Console.WriteLine();
Create(list, n);
Console.WriteLine();

static void Print(int[] s)
{
    for (int i = 0;i < s.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(s[i] + "\t");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
}

Print(list);

int sum = 0;
int col = 0;

for (int i =0; i < list.Length; i++)
{
    if (list[i] % 2 == 0)
    {
        sum += list[i];
        col++;
    }
}

Console.WriteLine("Сумма = " + sum);
Console.WriteLine("Кол-во = " + col);