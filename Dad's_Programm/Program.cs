string? str, col;
int n, m, answer = 0, za = 0, dohod = 0;
bool isNum;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("[Start Program]");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите номер блюда: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    str = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    isNum = int.TryParse(str, out n);

    if (isNum)
    {
        n = Convert.ToInt32(str);
    }
    else if (str.Trim() == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[Вы ничего не ввели]");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[Введите только цифру]");
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (isNum == false);

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите кол-во блюд: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    col = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    isNum = int.TryParse(col, out m);

    if (isNum)
    {
        m = Convert.ToInt32(col);
    }
    else if (col.Trim() == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[Вы ничего не ввели]");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[Введите только цифру]");
        Console.ForegroundColor = ConsoleColor.White;
    }

} 
while (isNum == false);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Чистый доход = {answer} \t Затраты на продукты {za} \t Доход = {dohod}");
Console.ForegroundColor = ConsoleColor.White;