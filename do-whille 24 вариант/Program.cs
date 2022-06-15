string? m;
int n; 
int sum = 0;
int minute = 0;
bool isNum;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("'000' - выход из программы");
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Введите кол-во метров пройденых за минуту: ");
m = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;

do
{
    isNum = int.TryParse(m, out n);

    if (isNum == false)
    {
        if (m == "" || m == " " || m == "   " || m == "    " || m == "     " || m == "      ")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели строку");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else
    {
        if (n < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели отрицательное число");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            n = Convert.ToInt32(m);
        }
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Введите кол-во метров пройденых за минуту: ");
    m = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    minute += 1;
    sum += n;
}
while (sum < 17 && minute != 15 && m != "000");

if (sum >= 17)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Муравей уcпел добажать до захода солнца");
    Console.WriteLine($"Пробежал --> {sum} m");
    Console.WriteLine($"Прошло {minute} минут");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (minute == 15)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Муравей не уcпел добажать до захода солнца");
    Console.WriteLine($"Пробежал --> {sum} m");
    Console.WriteLine($"Прошло {minute} минут");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (m == "000")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("[Программа была остановлена]");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Муравей пробежал {sum} m");
    Console.WriteLine($"Прошло {minute} минут");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Что-то странное произошло");
    Console.ForegroundColor = ConsoleColor.White;
}
