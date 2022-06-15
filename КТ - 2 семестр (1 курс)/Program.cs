// // Первое задание

// Console.ForegroundColor = ConsoleColor.Cyan;
// Console.Write("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.ForegroundColor = ConsoleColor.White;

// Console.ForegroundColor = ConsoleColor.Cyan;
// Console.Write("Введите размер массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.ForegroundColor = ConsoleColor.White;

// int[] array = new int[n];
// int[] array2 = new int[m];

// static void Vod(int[] list)
// {
// 	for (int i = 0; i < list.Length; i++)
// 	{
// 		Console.Write($"Введите [{i}] элемент: ");
// 		Console.ForegroundColor = ConsoleColor.Green;
// 		list[i] = Convert.ToInt32(Console.ReadLine());
// 		Console.ForegroundColor = ConsoleColor.White;
// 	}
// }

// static void Print(int[] list)
// {
// 	for (int i = 0; i < list.Length; i++)
// 	{
// 		Console.Write(list[i] + "\t");
// 	}
// 	Console.WriteLine();
// }

// static void fun (int[] list)
// {
// 	for (int i = 0; i < list.Length; i++)
// 	{
// 		if (i % 2 == 0)
// 		{
// 			list[i] = list[i]*2;
// 		} 
// 		else 
// 		{
// 			list[i] = list[i]/2;
// 		}
// 	}
// 	Console.WriteLine();
// }

// Vod(array);
// Vod(array2);

// Console.ForegroundColor = ConsoleColor.Yellow;
// Print(array);
// Console.WriteLine();
// Print(array2);
// Console.ForegroundColor = ConsoleColor.White;

// Console.WriteLine();
// fun(array);
// fun(array2);

// Console.ForegroundColor = ConsoleColor.Green;
// Print(array);
// Console.WriteLine();
// Print(array2);
// Console.ForegroundColor = ConsoleColor.White;

// Второе задание

// Console.Write("Введите строки массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбцы массива: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] Array = new int[n, m];

// Console.Write("Введите строки 2-ого массива: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите столбцы 2-ого массива: ");
// int m1 = Convert.ToInt32(Console.ReadLine());

// int[,] Array2 = new int[n1, m1];

// static void Vod(int[,] list)
// {
// 	for (int i = 0; i < list.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < list.GetLength(1); j++)
// 		{
// 			Console.Write($"Введите [{i}, {j}] элемент: ");
// 			list[i, j] = Convert.ToInt32(Console.ReadLine());
// 		}
// 	}
// 	Console.WriteLine();
// }


// static void Print(int[,] list)
// {
// 	for (int i = 0; i < list.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < list.GetLength(1); j++)
// 		{
// 			Console.Write(list[i, j] + "\t");
// 		}
// 		Console.WriteLine();
// 	}
// 	Console.WriteLine();
// }

// static int fun(int[,] list)
// {
// 	int pro = 1;

// 	for (int i = 0; i < list.GetLength(0); i++)
// 	{
// 		for (int j = 0; j < list.GetLength(1); j++)
// 		{
// 			if (i != j)
// 			{
//                 if (list[i, j] == Math.Abs(i - j))
// 				{
// 					pro *= list[i, j];
// 				}
// 			}
// 		}
// 	}
// 	return pro;
// }


// Vod(Array);

// Vod(Array2);

// Console.ForegroundColor = ConsoleColor.Red;
// Print(Array);
// Console.ForegroundColor = ConsoleColor.White;

// Console.ForegroundColor = ConsoleColor.Cyan;
// Print(Array2);
// Console.ForegroundColor = ConsoleColor.White;

// Console.WriteLine();
// Console.ForegroundColor = ConsoleColor.Green;
// Console.WriteLine($"Произведение первого массива = {fun(Array)}");
// Console.WriteLine($"Произведение первого массива = {fun(Array2)}");
// Console.ForegroundColor = ConsoleColor.White;


// Третье задание

// Console.Write("Введите размер массивов: ");
// Console.ForegroundColor = ConsoleColor.Red;
// int n = Convert.ToInt32(Console.ReadLine());
// Console.ForegroundColor = ConsoleColor.White;

// Console.Write("Введите до какого элемента вывести массив: ");
// Console.ForegroundColor = ConsoleColor.Red;
// int a = Convert.ToInt32(Console.ReadLine());
// Console.ForegroundColor = ConsoleColor.White;


// int[] list = new int[n];
// string[]? list2 = new string[n];
// bool[] list3 = new bool[n];

// static void Print<T>(T[] list, int a)
// {
// 	for (int i = 0; i < a; i++)
// 	{
// 		Console.Write(list[i] + "\t");
// 	}
// 	Console.WriteLine();
// }

// for (int i = 0; i < list.Length; i++)
// {
// 	Console.Write($"Введите [{i}] элемент: ");
// 	Console.ForegroundColor = ConsoleColor.Green;
// 	list[i] = Convert.ToInt32(Console.ReadLine());
// 	Console.ForegroundColor = ConsoleColor.White;
// }

// for (int i = 0; i < list.Length; i++)
// {
// 	Console.Write($"Введите [{i}] элемент: ");
// 	Console.ForegroundColor = ConsoleColor.Green;
// 	list2[i] = Console.ReadLine();
// 	Console.ForegroundColor = ConsoleColor.White;
// }

// for (int i = 0; i < list.Length; i++)
// {
// 	Console.Write($"Введите [{i}] элемент: ");
// 	Console.ForegroundColor = ConsoleColor.Green;
// 	list3[i] = Convert.ToBoolean(Console.ReadLine());
// 	Console.ForegroundColor = ConsoleColor.White;
// }

// Print(list, a);
// Print(list2, a);
// Print(list3, a);

// Четвертое задание

// Console.Write("Введите x: ");
// double x = Convert.ToDouble(Console.ReadLine());

// Console.Write("Введите e: ");
// double E = Convert.ToDouble(Console.ReadLine());

// double Factorial(double n)
// {
//     if (n <= 1) return 1;
//     return n * Factorial(n - 1);
// }


// double fun(double e, double x, double i = 0)
// {
//     double res = (Math.Pow((-1), i) / Math.Pow(Factorial(i+1), 2) * Math.Pow((x / 2), 2 * (i+1)));
//     if (res <= e) return 1;
//     return fun(e, x, i+1) + res;
// }

// Console.WriteLine(fun(E, x));

// вы не представляете, но перегрузка оказвается из-за Факториала. // Не знаю точно, но скорее всего это из-за того, 
// что в строке 225 где лежит вся функция, я пишу i = 0; 
// И вот какое дело, факториал повторяет функция пока она не равна 1, 
// если она не == 1, то возвращает функцию n - 1, то есть если это 0, 
// то она будет уменьшаться бесконечно, и когда я заменил == на <= в 218 строке, т
// о все заработало
// и я ломал голову над этим 2 часа, найс