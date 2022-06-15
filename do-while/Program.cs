string? str, str2;
int n;
int sum = 0;
bool isNum;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Будете еще вводить? (y/n)");
Console.ForegroundColor = ConsoleColor.White;
str2 = Console.ReadLine();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Сколько людей в ряду?");
    Console.ForegroundColor = ConsoleColor.White;

    str = Console.ReadLine();
    isNum = Int32.TryParse(str, out n);

    if (isNum)
    {
        if (n < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели отрицательное число, введите положительное число");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            n = Convert.ToInt32(str);
        }
    }
    else
    {
        if (str == "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели, пожалуйсте введите число");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели строку, пожалуйсте введите число");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    sum = sum + n;

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Будете еще вводить? (y/n)");
    Console.ForegroundColor = ConsoleColor.White;


    str2 = Console.ReadLine();
}
while (str2 == "y" & sum < 100);
if (sum < 100)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"Мест заполнено --> {sum}");
    Console.WriteLine($"sum = {sum}");
    Console.WriteLine($"n = {n}");
    Console.ForegroundColor = ConsoleColor.Green;
}
else
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Места заполнены");
    Console.WriteLine($"последнее введенное кол-во людей = {n}");
    Console.ForegroundColor = ConsoleColor.Green;
}

Console.WriteLine($"Заполнено --> {sum}, соответсвенно у нас на {sum-100} больше, чем необходимо");
