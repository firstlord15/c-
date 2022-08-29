using System;
using System.IO;


StreamReader sr = new StreamReader("test.txt");
string str = sr.ReadToEnd();

int m = 1;

str = str.Replace("Максимальный", "Наибольший");
str = str.Replace("Иванов И.И.", "");

char[] ch = str.ToCharArray();

for (int i = 0; i < str.Length; i++)
{
    if (ch[i] == '.')
    {
        if (ch[i+1] == ' ')
        {
            m++;
        }
    }
}

Console.WriteLine(str.Trim());

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Кол-во предложений = {m}");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine();



// второе задание


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Second");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

bool fres = false;


for (int i = 0; i < ch.Length; i++)
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

for (int i = 0; i < ch.Length; i++)
{
    Console.Write(ch[i]);
}


string[] slova = str.Split(' ');
int counter = 0;

foreach (string s in slova)
{
    if (s.ToLower().StartsWith("а"))
        counter++;
}

Console.WriteLine();
Console.WriteLine($"Кол-во слов на букву А = {counter}");