using System;
/*
 * public class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введите значение x1:");
        double x1 = Convert.ToDouble(Console.ReadLine());

        double result1 = 1 - Math.Pow(x1, 7) + Math.Sin(x1) - Math.Log(Math.Abs(1 + x1), Math.Exp(1));
        Console.WriteLine($"Результат первой функции = {result1}");

        Console.WriteLine("Введите значение x2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double result2 = 3 * x2 - Math.Sqrt(3.7 * x2) + Math.Pow(Math.Exp(1), x2 + 5);
        Console.WriteLine($"Результат второй функции = {result2}");
    }
}
*/

public class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введите значение x1:");
        double x1 = Convert.ToDouble(Console.ReadLine());

        double result1 = Math.Sin(Math.Log(Math.Abs(x1), Math.Exp(1))) + Math.Pow(x1, 1/3);
        Console.WriteLine($"Результат первой функции = {result1}");

        Console.WriteLine("Введите значение x2:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        double result2 = Math.Log(0.7*x2, Math.Exp(1)) - Math.Pow(Math.Cos(x2), 7);
        Console.WriteLine($"Результат второй функции = {result2}");
    }
}
