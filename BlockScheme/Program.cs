// 7 вариант

bool isNum;
int xn, y;
string? joke;

Console.ForegroundColor = ConsoleColor.Yellow;

while (true)
{
    Console.Write("Хотите дальше? (y/n)");
    joke = Console.ReadLine();

    if (joke == "y")
    {
        break;
    }
    else
    {
        Console.WriteLine("Okay");
    }
}
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("");

do
{
    Console.ForegroundColor= ConsoleColor.Cyan;
    Console.Write("Введите значение x: ");
    string? x = Console.ReadLine();

    isNum = int.TryParse(x, out xn);

    if (isNum)
    {
        xn = Convert.ToInt32(x);
    } 
    else
    {
        if (x == "" || x == " ")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели");
            Console.ForegroundColor = ConsoleColor.White;
        } 
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели строку ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
} while (isNum == false);

if (xn < 0)
{
    y = xn;
}
else if (xn < 2)
{
    y = xn + 2;
}
else
{
    y = xn / 2;
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"y = {y}");