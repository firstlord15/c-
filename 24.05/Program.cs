Console.Write("Введите строки массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] arr = new string[n];

static void Input(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"Введите [{i+1}] текст: ");
		array[i] = Console.ReadLine();
	}
}

Input(arr);

static void Print(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine(array[i]);
		Console.ForegroundColor = ConsoleColor.White;
	}
}

Print(arr);

Console.Write("Какую строку вы хотите удалить?: ");
string? word = Console.ReadLine();

static string[] Change(string[] array, string word)
{
	for (int i = 0; i < array.Length; i++)
    {
		string str = array[i];
		str = str.ToLower().Replace(word.ToLower(), "");
		array[i] = str;
	}
	return array;
}

Change(arr, word);
Print(arr);