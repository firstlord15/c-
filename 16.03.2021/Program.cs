Char n;
int k = 0;
int k1 = 0;

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("введите координату х: ");
    Double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("введите координату y: ");
    Double y = Convert.ToDouble(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;
    switch (x, y)
    {
        case ( > 0, > 0):
            {
                if (x >= 3 && x <= 4 && y <= 2)
                {
                    if (Math.Pow(x, 2) + Math.Pow(y, 2) >= 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Точка лежит в области");
                        Console.ForegroundColor = ConsoleColor.White;
                        k++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Точка не лежит в области");
                        Console.ForegroundColor = ConsoleColor.White;
                        k1++;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Точка не лежит в области");
                    Console.ForegroundColor = ConsoleColor.White;
                    k1++;
                }
            }
            break;
        case ( <= 0, <= 0):
            {
                if (x >= -3 && y >= -2)
                {
                    if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Точка лежит в области");
                        Console.ForegroundColor = ConsoleColor.White;
                        k++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Точка не лежит в области");
                        Console.ForegroundColor = ConsoleColor.White;
                        k1++;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Точка не лежит в области");
                    Console.ForegroundColor = ConsoleColor.White;
                    k1++;
                }
            }
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Точка не лежит в области");
            Console.ForegroundColor = ConsoleColor.White;
            k1++;
            break;
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Хотите ли вы ввести еще точку: ");
    n = Convert.ToChar(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;
} while (n == 'Y');

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Точек не лежащих в области {k1}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Точек лежащих в области {k}");
Console.ForegroundColor = ConsoleColor.White;