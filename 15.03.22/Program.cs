/*
string name = "r";
 
Console.Write("Введите букву: ");
name = Console.ReadLine();
string? nameu = name.ToUpper();


switch (nameu)
{
    case "A":
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Ani Lorak");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "E":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Eldar Jarakhov");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "V":
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Vera Brezhneva");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "K":
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Korvo Atano");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "N":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nadya Dorofeeva");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "M":
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Micheal Jackson");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "R":
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Ashimov Ratmir");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "T":
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Tom Holland");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "L":
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Catherine Buzhinskaya ");
        Console.ForegroundColor = ConsoleColor.White;
        break;
    case "S":
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Scarlett Johansson");
        Console.ForegroundColor = ConsoleColor.White;
        break;
}

*/


/*

string? line;
int n;
bool isNum;

do
{ 
    Console.Write("Введите сколько прошло дней: ");
    line = Console.ReadLine();

    isNum = int.TryParse(line, out n);

    if (isNum)
    {
        n = Convert.ToInt32(line);
    }
    else
    {
        if (line == "" || line == " " || line == "  ")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели!");
            Console.BackgroundColor = ConsoleColor.White;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели строку!");
            Console.BackgroundColor = ConsoleColor.White;
        }
    }
} while (isNum == false);

int day = 1;
int month = 1;
int years = 2000;

int v_years = (years - 2000) % 4;

bool yeartf = true;

if (v_years == 0)
{
    yeartf = true;
}
else
{
    yeartf = false;
}

for (int i = 0; i < n; i++)
{
    day += 1;
    
    if (month == 13)
    {
        years += 1;
        month = 1;
    }

    if (day == 29)
    {
        if (month == 2 && yeartf == false)
        {
            month += 1;
            day = 1;
        }
    }

    else if (day == 30)
    {
        if (month == 2 && yeartf)
        {
            month += 1;
            day = 1;
        }
    }

    else if (day == 31)
    {
        if (month % 2 == 0)
        {
            month += 1;
            day = 1;
        }
    }

    else if (day == 32)
    {
        if (month % 2 != 0)
        {
            month += 1;
            day = 1;
        }
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Answer = {day}.{month}.{years}");
Console.ForegroundColor = ConsoleColor.White;

*/

/*
 
string? line;
int n;
bool isNum;

do
{
    Console.Write("Введите число: ");
    line = Console.ReadLine();

    isNum = int.TryParse(line, out n);

    if (isNum)
    {
        n = Convert.ToInt32(line);
    }
    else
    {
        if (line == "" || line == " " || line == "  ")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели строку!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


} while (isNum == false);

switch (n) {
    case 4: case 5: case 6: case 7: case 8:
        Console.WriteLine("Забрызган днем");
        break;
    case 3: case 9: case 12: 
        Console.WriteLine("Исцарапан");
        break ;
    case 1: case 2: case 10: case 11:
        Console.WriteLine("Все нормально");
        break;
    default: Console.WriteLine("Можно вводить от 1 до 12");
        break;
}
 
 */