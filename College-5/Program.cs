using System;

/* try
{
    int a = 33;
    int b = 600;

    byte c = checked((byte)(a+b));
    Console.WriteLine(c);
}
catch (OverflowException ex)
{
    Console.WriteLine("Ошибочка");
    Console.WriteLine(ex.Message);
} */

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Введите двухзначное целое число: ");
int x = Convert.ToInt32(Console.ReadLine());

int first = x / 10;
// Console.WriteLine(first);
int second = x % 10;
// Console.WriteLine(second);

Console.WriteLine($"Сумма цифр вашего числа = {first + second}");
