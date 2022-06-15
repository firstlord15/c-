Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\tЗадание 1");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Текст: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
char[] str =
{
    'Я', ' ', 'Р', 'A', 'Т', 'М', 'И', 'Р', 'a', ' ', 
    'Д', 'Р', 'у', 'ж', 'и', 'Е', ' ', 
    'Т', 'a', 'К', '-', 'Т', 'о'
};

int[] index = new int[str.Length];
int m = 0, z = 0;

for (int i = 0; i < str.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(Char.ToUpper(str[i]) + " ");
    Console.ForegroundColor = ConsoleColor.White;
}


foreach (char c in str)
{
    if (Char.ToUpper(c) == 'А' || Char.ToUpper(c) == 'A')
    {
        index[m] = z;
        m++;
    }
    z++;
}

int col = 0;

for (int i = 0; i < str.Length; i++)
{
    if (i == index[col])
    {
        str[i] = 'Я';
        col++;
    }
}

Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ответ: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();


for (int i = 0; i < str.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(Char.ToUpper(str[i]) + " ");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\tЗадание 2");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();


string? line1, line2, line3;

Console.Write("Введите первое слово: ");
line1 = Console.ReadLine();

Console.Write("Введите второе слово: ");
line2 = Console.ReadLine();

Console.Write("Введите третье слово: ");
line3 = Console.ReadLine();

int n = line1.Length + line2.Length + line3.Length + 3;
int h = 0, h1 = 0, h2 = 0;

char[] arr = new char[n];

for (int i = 0; i < n; i++)
{
    if (i < line1.Length)
    {
        arr[i] = line1[h];
        h++;
    }
    else if (i == line1.Length)
    {
        arr[i] = ',';
    }
    else if (i > line1.Length && i < line1.Length + line2.Length + 1)
    {
        arr[i] = line2[h1];
        h1++;
    }
    else if (i == line1.Length + line2.Length + 1)
    {
        arr[i] = ',';
    }
    else if (i > line1.Length + line2.Length + 2 && i < n)
    {
        arr[i] = line3[h2];
        h2++;
    } 
}


for (int i = 0; i < n; i++)
{
    Console.Write(arr[i]);
}