// First work

/*
 
Console.Write("Введите текст: ");
string? str = Console.ReadLine();


char[] ch = str.ToCharArray();

for (int i = 0; i < str.Length; i++)
{
    for (int j = 0; j < str.Length-i; j++)
    {
        Console.Write(ch[j]);
    }
    Console.WriteLine();
}

 */

// Second Work

/*
 
Console.Write("Введите текст: ");
string? str = Console.ReadLine();

Console.Write("Введите длину слова: ");
int x = Convert.ToInt32(Console.ReadLine());

string[] Sarray = str.Trim().Split(' ');



string[] Vd = new string[Sarray.Length];
int col = 0;

for (int i = 0; i < Sarray.Length; i++)
{
    if (Sarray[i].Length > x)
    {
        Vd[col] = Sarray[i];
        col++;
    }
}

Console.WriteLine();
Console.Write("Слова которые длинее заданого значения: ");
for (int i = 0; i < Sarray.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(Vd[i] + " ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Кол-во слов = {Sarray.Length}");
Console.ForegroundColor = ConsoleColor.White;
 
 */


// Third work

/*
 
Console.Write("Введите число: ");
string? str = Console.ReadLine();

char[] ch = str.ToCharArray();

char x = ch[0];
ch[0] = ch[ch.Length - 1];
ch[ch.Length - 1] = x;

for(int i = 0; i < ch.Length; i++)
{
    Console.Write(ch[i]);
}

 */

// fourth work

/*
 
Console.Write("Введите размер списка: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] Sarray = new string[n];

for (int i = 0; i < Sarray.Length; i++)
{
    Console.Write($"Введите [{i}] предложение: ");
    Sarray[i] = Console.ReadLine();
}


for (int i = 0; i < n; i++)
{
    string[] slova = Sarray[i].Split(' ');
    for (int k = 0; k < slova.Length; k++)
    {
        char[] ch = slova[k].ToCharArray();

        bool fres = char.IsLower(ch[0]);

        if (fres == false)
        {
            Console.Write(slova[k] + " ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine();

 */