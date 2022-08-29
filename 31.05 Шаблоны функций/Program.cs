Console.Write("Введите строки массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбцы массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Random rn = new Random();

int[,] arr = new int[n,m];
double[,] arr2 = new double[n,m];

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		arr[i, j] = rn.Next(20);
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		arr2[i, j] = rn.Next(20);
	}
}

static void Print<T>(T[,] list)
{
	for (int i = 0; i < list.GetLength(0); i++)
	{
		for (int j = 0; j < list.GetLength(1); j++)
		{
			Console.Write(list[i, j] + "\t");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Yellow;
Print(arr);
Console.ForegroundColor = ConsoleColor.White;

Console.ForegroundColor = ConsoleColor.Cyan;
Print(arr2);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

static void fun<T>(T[,] list)
{
	int sum = 1;
	for (int i = 0; i < list.GetLength(1); i++)
	{
		for (int j = 0; j < list.GetLength(0); j++)
		{
			sum = Convert.ToInt32(list[j, i]) * sum;
		}
		Console.WriteLine(sum);
		sum = 1;
	}
	Console.WriteLine();
}

fun(arr);
fun(arr2);