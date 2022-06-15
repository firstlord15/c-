string? str;
int n = 0;
int x = 0;
int sum = 0;
int first = 0, second = 0;
bool isNum = true;

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Введите размер массива: ");
    str = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    isNum = int.TryParse(str, out n);    

    if (isNum)
    {
        n = Convert.ToInt32(str);
    } else if (str.Trim() == "")
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Вы ничего не ввели");
        Console.ForegroundColor = ConsoleColor.White;
    } else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы ввели строку, вводите только цифры!");
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (isNum == false);

int[] list;
list = new int[n];

for (int i = 0; n > i; i++)
{
    Console.Write($"Введите [{i}] элемент: ");
    x = Convert.ToInt32(Console.ReadLine());
    list[i] = x;
}

// Первое задаие

int mxv = list.Max();
int inmx = 0;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"MaxValue = _{mxv}_");
Console.ForegroundColor = ConsoleColor.White;

for (int i = 0; n > i; i++)
{
    if (list[i] == mxv)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Индекст MaxValue = [{i}]");
        Console.ForegroundColor = ConsoleColor.White;
        inmx = i;
    }
}

// Втрое задание
int z = 0;
int zz = 0;

for (int i = 0; n > i; i++)
{
    if (list[i] == 0 && z == 0)
    {
        first = i;
        z += 1;
    }
    else if (list[i] == 0 && z > 0 && z < 2)
    {
        second = i;
        z += 1;
    }
}

zz = first+1;

while (zz < second)
{
    if (first < zz && zz < second)
    {
        sum = sum + list[zz];
        zz++;
    }
}

Console.WriteLine($"first = {first}");
Console.WriteLine($"second = {second}");
Console.WriteLine($"Ну вот ответ = {sum}");

// Третье задание

list[0] = sum;
list[n-1] = inmx;

for (int i = 0; n > i; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{list[i]} ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine("");
// Четвертое задание 

int temp;

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (list[i] > list[j])
        {
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}

for (int i = 0; n > i; i++)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{list[i]} ");
    Console.ForegroundColor = ConsoleColor.White;
}