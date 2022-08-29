Console.Write("Укажите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

Random rn = new Random();

for (int i = 0; i < n; i++)
{
	arr[i] = rn.Next(15);
}

for (int i = 0; i < n; i++)
{
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.Write(arr[i] + " ");
	Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();

int ListSum(int[] list, int n, int sum = 0)
{
	if (n == -1) return sum;

	sum = sum + list[n];
	return ListSum(list, n-1, sum);

}
Console.WriteLine();


Console.WriteLine("Сумма = " + ListSum(arr, n-1));