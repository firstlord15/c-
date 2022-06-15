/*
double x = 1, y;
double d = 0.5;
double fu = 0.305;
double yad = 0.914;


while (x >= 1 && x < 10)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Kilometrs = {x} km");
    Console.WriteLine($"Fut = {x*fu*1000} fu");
    Console.WriteLine($"Yadra = {x*yad*1000} ya");
    Console.WriteLine($"metrs = {x*1000} m");
    Console.WriteLine("_____________________________");
    Console.ForegroundColor = ConsoleColor.White;
    x += d;
}
*/

/*
 
string? line, line2;
int n = 0;
bool isNum;

double P = 0, H = 0;

do
{
    Console.Write("Введите P: ");
    line = Console.ReadLine();

    isNum = double.TryParse(line, out P);

    if (isNum)
    {
        P = Convert.ToInt32(line);
    }
    else
    {
        if (line.Trim() == "")
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

do
{
    Console.Write("Введите H: ");
    line2 = Console.ReadLine();

    isNum = double.TryParse(line2, out H);

    if (isNum)
    {
        H = Convert.ToInt32(line2);
    }
    else
    {
        if (line.Trim() == "")
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



while (P <= H)
{
    P = P / 3 * 2;
    n++;
    Console.WriteLine($"P = {P}");
}

Console.WriteLine($"Прыжок = {n}");

 */

// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55

/*

double k, x = 0, x1 = 1, y = 0;
int n = 2;

Console.Write("Введите число k: ");
k = Convert.ToDouble(Console.ReadLine());

while (n <= k)
{
    y = x + x1;

    x = x1;
    x1 = y;
    n++;
}

Console.WriteLine(y);

*/

/*
int k;

Console.Write("Введите число : ");
k = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (k > 0)
{
    i++;
    k /= 10;
}
Console.WriteLine("Количество цифр введенного числа : {0}", i);

*/