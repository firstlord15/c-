Random rn = new Random();

// Очистка файлов!

Console.WriteLine("Хотите ли вы очистить файлы? Если да, то пожалуйста напишите название или all, а если нет, то напишите No: ");
string? answer = Console.ReadLine();
Console.WriteLine();

if (answer.ToLower() == "all")
{
    File.WriteAllText(@"text1.txt", string.Empty);
    File.WriteAllText(@"number1.txt", string.Empty);
    File.WriteAllText(@"number2.txt", string.Empty);
    File.WriteAllText(@"number3.txt", string.Empty);
    File.WriteAllText(@"text2.txt", string.Empty);
}

// Запись text1.txt

StreamWriter text1 = new StreamWriter("text1.txt");
text1.Write("\n");
text1.Write("\n");
text1.Write("\n");
text1.Write("Abs Base Codes Data E Feel Girl High Iron Kill Learn Moon Not Out Pen Quit Rus Sea TV View X Year Zad");
text1.Write("\n");
text1.Write("\n");
text1.Write("\n");
text1.Write("\n");
text1.Close();

// Запись number1.txt

StreamWriter number1 = new StreamWriter("number1.txt");
Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] size = new int[n];


for (int i = 0; i < n; i++)
{
    size[i] = rn.Next(0, 10);
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < size[i]; j++)
    {
        number1.Write(Convert.ToString(rn.Next(-10, 10)) + "\t");
    }
    number1.Write("\n");
}


number1.Close();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[All Ready]");
Console.ForegroundColor = ConsoleColor.White;

// Считываем данные с number1.txt

StreamReader sr = new StreamReader("number1.txt");
string str = sr.ReadToEnd();
Console.WriteLine(str);
sr.Close();
Console.WriteLine();

// Считанные данные с number1.txt разделяем от друг друга по \n and \t

string[] numS = str.Split('\n', '\t');
int col = 0, check;

// определяем размер массива цифр

for (int i = 0; i < numS.Length; i++)
{
    bool fres = int.TryParse(numS[i], out check);
    if (fres && Convert.ToInt32(numS[i]) > 0)
    {
        col = col + 1;
    }
}

int[] numI = new int[col];

// Переделаем массив строк в массив цифр

col = 0;
for (int i = 0; i < numS.Length; i++)
{
    bool fres = int.TryParse(numS[i], out check);
    if (fres && Convert.ToInt32(numS[i]) > 0)
    {
        numI[col] = Convert.ToInt32(numS[i]);
        col++;
    }
}


// Факториал

int Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}

// переделываем данные из массива в его факториалы

for (int i = 0; i < numI.Length; i++)
{
    numI[i] = Factorial(numI[i]);
}

Console.WriteLine();
for (int i = 0; i < numI.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(numI[i]);
    Console.ForegroundColor = ConsoleColor.White;
}

// Записываем факториал чисел на файл number3.txt

StreamWriter num2 = new StreamWriter("number3.txt");
num2.WriteLine("Тут будет факториал чисел с первого файла)");
num2.WriteLine();

for (int i = 0; i < numI.Length; i++)
{
    num2.WriteLine($"[{i}] --> {numI[i]}");
}
num2.Close();

// теперь запишем в файле number2.txt кол-во чисел > factorial(5)

int result = 0;
int fa5 = Factorial(5);
for (int i = 0; i < numI.Length; i++)
{
    if (numI[i] > fa5)
    {
        result++;
    }
}

StreamWriter num3 = new StreamWriter("number2.txt");
num3.WriteLine("Кол-во чисел > Factorial(5)");
num3.WriteLine($"Result = {result}");
Console.WriteLine($"Result = {result}");
num3.Close();

// Очищяем пустые строки в text1.txt

StreamReader Rtext1 = new StreamReader("text1.txt");
string strt = Rtext1.ReadToEnd();
string[] list_strt = strt.Split('\n');

StreamWriter Wtext2 = new StreamWriter("text2.txt");

for (int i = 0;i < list_strt.Length; i++)
{
   if (list_strt[i] != "\n")
    {
        Wtext2.Write(list_strt[i]);
    }
}

Wtext2.Close();