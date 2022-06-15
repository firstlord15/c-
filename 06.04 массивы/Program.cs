Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k: ");
int k = Convert.ToInt32(Console.ReadLine());


int[,] Array = new int[n, m];
Random rn = new Random();

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		Array[i, j] = rn.Next(20);
	}
}

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		Console.Write(Array[i, j] + "\t");
	}
	Console.WriteLine();
}

int pro = 1;

for (int i = 0; i < n; i++)
{
	for (int j = 0; j < m; j++)
	{
		if (Array[i, j] % k == 0)
		{
			pro = pro * Array[i, j];
		}
	}
}

Console.WriteLine($"Произведение чисел кратных {k} == {pro}");