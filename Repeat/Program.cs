Console.Write("первую цифру диапозона пж, чмо: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("первую цифру диапозона пж, чмо: ");
int b = Convert.ToInt32(Console.ReadLine());

int i = a;
int chet = 0, nchet = 0;
int sumch = 0, sumn = 0;

while (i <= b)
{
    if (i % 2 == 0)
    {
        chet += 1;
        sumch = sumch + i;
    } 
    else
    {
        nchet += 1;
        sumn = sumn + i;
    }

    i++;
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Четных чисел в диапозоне от {a} до {b}, {chet} шт.");
Console.WriteLine($"Нечетных чисел в диапозоне от {a} до {b}, {nchet} шт.");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Сумма четных = " + sumch + " Сумма не четных = " + sumn);
Console.ForegroundColor = ConsoleColor.White;