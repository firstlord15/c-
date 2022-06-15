//int[,] list = new int[5,6];

//Random rn = new Random();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        list[i, j] = rn.Next(20);
//    }
//}

//static void Print<T>(T[,] list)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.Write(list[i, j] + "\t");
//            Console.ForegroundColor = ConsoleColor.White;
//        }
//        Console.WriteLine();
//    }
//}

//int sum = 0;

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if (i == j)
//        {
//            sum += list[i, j];
//        }
//    }
//}

//Print(list);

//Console.WriteLine("sum == " + sum);


Console.Write("Число: ");
int a = Convert.ToInt32(Console.ReadLine());

static int Factorial(int x)
{
    if (x <= 1)
        return 1;
    else
        return x * Factorial(x - 1);
}

Console.WriteLine(Factorial(a));