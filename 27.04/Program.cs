// первое задание

/*
 
int m = 0;
string? str, str2, str3;


Console.Write("Введите текст: ");
str = Console.ReadLine();

char[] ch = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    ch[i] = str[i];
    if (ch[i] == '.')
    {
        m++;
    }
}

str2 = str.Replace("Максимальный", "Наибольший");
str3 = str2.Replace("Иванов И.И.", "");

Console.WriteLine(str3.Trim());
if (m == 0)
{
    Console.WriteLine($"Кол-во предложений = 1");
} 
else
{
    Console.WriteLine($"Кол-во предложений = {m}");
}

 
 */

// второе задание
/*
 
string? str;
bool fres = false;

Console.Write("Введите текст: ");
str = Console.ReadLine();

str = str.Replace("#", "");

char[] ch = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    ch[i] = str[i];
}

for (int i = 0; i < str.Length; i++)
{
    if (ch[i] == '.')
    {
        fres = char.IsLower(ch[i + 2]);
        if (fres)
        {
            ch[i+2] = char.ToUpper(ch[i + 2]);
        }
    }
}

int counter = 0;

string[] s_mass = str.Split(' ');
foreach (string s in s_mass)
{
    if (s.ToLower().StartsWith("а"))
    {
        counter++;
    }
}

for (int i = 0; i < ch.Length; ++i)
{
    Console.Write(ch[i]);
}
Console.WriteLine();
Console.WriteLine($"Кол-во слов на букву А = {counter}");
 
 */

