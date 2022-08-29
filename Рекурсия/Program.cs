// Факториал

Console.Write("Введите данные: ");
int n = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)
{
	if (n == 1) return 1;
	return n * Factorial(n-1);
}

Console.WriteLine(Factorial(n));

// Число фибоначи

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}
