string? a = "", b = "", d = "";
double a1 = 0, b1 = 0, d1 = 0, sum = 0;
bool isNum1, isNum2, isNum3;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("a <= x <= b");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;

do
{
    Console.Write("Введите a: ");
    a = Console.ReadLine();

    isNum1 = double.TryParse(a, out sum);

    if (isNum1 == false)
    {
        if (a == "" || a == " ")
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
        a1 = Convert.ToDouble(a);
    }
} 
while (isNum1 == false);


do
{
    Console.Write("Введите b: ");
    b = Console.ReadLine();

    isNum2 = double.TryParse(b, out sum);

    if (isNum2 == false)
    {
        if (b == "" || b == " ")
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
        b1 = Convert.ToDouble(b);
    }
}
while (isNum2 == false);


do
{
    Console.Write("Введите шаг: ");
    d = Console.ReadLine();

    isNum3 = double.TryParse(d, out sum);

    if (isNum3 == false)
    {
        if (d == "" || d == " ")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели");
            Console.ForegroundColor = ConsoleColor.White;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели строку");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else
    {
        d1 = Convert.ToDouble(d);
    }
}

while (isNum3 == false);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("___________________________________________");
Console.WriteLine("\t x \t | \t f \t");
Console.WriteLine("___________________________________________");


for (double i = a1; i <= b1; i += d1)
{
    double fun = 5 * (1 - Math.Pow(Math.Exp(1), -0.5 * i) * Math.Cos(2 * Math.PI * i));

    Console.WriteLine($"\t {i} \t | \t {fun}");
    Console.WriteLine("___________________________________________");


    if (fun > 0)
    {
        sum += fun;
    }
}



Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("");
Console.WriteLine($"Сумма всех положительных чисел = {sum}");
Console.ForegroundColor = ConsoleColor.White;
