Random rn = new Random();

StreamWriter number1 = new StreamWriter("number1.txt");
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] size = new int[n];

static void print(int[] Array, string text)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(text + " = " + Array[i]);
    }
}

for (int i = 0; i < n; i++)
{
    size[i] = rn.Next(0, 10);
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < size[i]; j++)
    {
        number1.Write(Convert.ToString(rn.Next(-100, 100)) + "\t");
    }
    number1.Write("\n");
}


number1.Close();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[All Ready]");
Console.ForegroundColor = ConsoleColor.White;

// Считываем данные с number1.txt

StreamReader sr = new StreamReader("number1.txt");
string textfile = sr.ReadToEnd();
sr.Close();
Console.WriteLine();

// Считанные данные с number1.txt разделяем от друг друга по \n and \t

string[] Array1 = textfile.Split('\n', '\t');
int f = 0, ch;

for (int i = 0; i < Array1.Length; i++)
{
    bool fres = int.TryParse(Array1[i], out ch);
    if (fres)
    {
        f = f + 1;
    }
}

// Переделаем массив строк в массив цифр
int[] Array2 = new int[f];

f = 0;
for (int i = 0; i < Array1.Length; i++)
{
    bool fres = int.TryParse(Array1[i], out ch);
    if (fres)
    {
        Array2[f] = Convert.ToInt32(Array1[i]);
        f++;
    }
}

int x = 0;
for (int i = 0; i < Array2.Length; i++)
{
    if (Array2[i] % 9 == 0)
    {
        x++;
    }
}

int[] Array3 = new int[x];

x = 0;
for (int i = 0; i < Array2.Length; i++)
{
    if (Array2[i] % 9 == 0)
    {
        Array3[x] = Array2[i];
        x++;
    }
}

print(Array2, "Array2");
Console.WriteLine();

print(Array3, "Кратные 9");

StreamWriter number2 = new StreamWriter("number2.txt");
for (int i = 0; i < Array3.Length; i++)
{
    number2.WriteLine($"Array3 [{i}] = {Array3[i]}");
}
number2.Close();

StreamWriter number3 = new StreamWriter("number3.txt");
number3.WriteLine($"Result = {x}");
number3.Close();

// переходим к text1.txt и text2.txt

StreamWriter Write_text1 = new StreamWriter("text1.txt");
Write_text1.Write("Lorem ipsum dolor sit Amet, consectetur Adipiscing elit, sed do Eiusmod tempor Incididunt ut labore et dolore magna aliqua.");
Write_text1.Close();

StreamReader Read_text1 = new StreamReader("text1.txt");
string Stext1 = Read_text1.ReadToEnd();

string[] String_list = Stext1.Split(' ');

StreamWriter Write_text2 = new StreamWriter("text2.txt");

for (int i = 0; i < String_list.Length; i++)
{
    if (char.IsUpper(String_list[i][0]))
    {
        Write_text2.WriteLine($"String[{i}] = {String_list[i]}");
    }
}
Write_text2.Close();


Console.WriteLine();
Console.WriteLine("[Программа завершила все задания]");