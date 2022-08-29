StreamWriter number1 = new StreamWriter("number1.txt");
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] size = new int[n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    size[i] = random.Next(0, 10);
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < size[i]; j++)
    {
        number1.Write(Convert.ToString(random.Next(1, 5)) + "\t");
    }
    number1.Write("\n");
}
number1.Close();


StreamReader sr = new StreamReader("number1.txt");
string str = sr.ReadToEnd();
Console.WriteLine(str);
sr.Close();

string[] array_string = str.Split('\n', '\t');
int[] array_int = new int[array_string.Length];

int b, a = 0;
for (int i = 0; i < array_int.Length; i++)
{
    bool fres = int.TryParse(array_string[i], out b);
    if (fres)
    {
        array_int[i] = Convert.ToInt32(array_string[i]);
    }
}

for (int i = 0; i < array_int.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write(array_int[i] + " ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();

// основная часть 

int[] array_int2 = new int[array_string.Length];
bool check = false;

for (int i = 0; i < array_string.Length; i++)
{
    for (int k = 0; k < array_string.Length; k++)
    {
        if (array_int[i] != array_int2[k] && array_int[i] != 0)
        {
            check = true;
            if (check)
            {
                array_int2[i] = array_int[i];
                Console.WriteLine($"chec");
            }
            check = false;
            break;
        }
    }
}

Console.WriteLine();

for (int i = 0; i < array_int2.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(array_int2[i] + " ");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(array_int.Count());
Console.ForegroundColor = ConsoleColor.White;
