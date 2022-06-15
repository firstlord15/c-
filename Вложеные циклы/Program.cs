bool isNum, tf = true;

string? N, x1;
int numN, y1 = 0, y2 = 0, i = 0;

do
{
    Console.Write("Введите N: ");
    N = Console.ReadLine();

    isNum = int.TryParse(N, out numN);

    if (isNum)
    {
        numN = Convert.ToInt32(N);
    }
    else
    {
        if (N == "" || N == " " || N == "  ")
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


} while (isNum == false);

Console.WriteLine();

do
{
    y2 = y1;

    do
    {
        

        Console.Write($"Введите x{i+1}: ");
        x1 = Console.ReadLine();

        isNum = int.TryParse(x1, out y1);

        if (isNum)
        {
            y1 = Convert.ToInt32(x1);
        }
        else
        {
            if (x1 == "" || x1 == " " || x1 == "  ")
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


    } while (isNum == false);


    if (y1 > 0 && y2 > 0)
    {
        tf = false;
    }
    else if (y1 < 0 && y2 < 0)
    {
        tf = false;
    }
    
    i++;

} while (i != numN) ;

if (tf == false)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("У вас последовательность не знакочередующейся");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("У вас последовательность знакочередующейся");
    Console.ForegroundColor = ConsoleColor.White;
}

Console.WriteLine($"последнее x1 = {y1}, последнее x2 = {y2}");

// я исправил)