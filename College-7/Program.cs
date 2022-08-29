double dd;

Console.WriteLine("a: ");
string? a1 = Console.ReadLine();

try
{
    dd = Convert.ToDouble(a1);
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введен неверный формат");
    Console.ForegroundColor = ConsoleColor.Green;
}

double a = Convert.ToDouble(a1);



Console.WriteLine("b: ");
string? b1 = Console.ReadLine();

try
{
    dd = Convert.ToDouble(b1);
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введен неверный формат");
    Console.ForegroundColor = ConsoleColor.Green;
}

double b = Convert.ToDouble(b1);

Console.WriteLine("x: ");
string? x1 = Console.ReadLine();

try
{
    dd = Convert.ToDouble(x1);
}
catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введен неверный формат");
    Console.ForegroundColor = ConsoleColor.Green;
}

double x = Convert.ToDouble(x1);

double result;

if (x <= 1)
{
    result = a * Math.Pow(Math.Cos(x), 2) - b * Math.Sin(Math.Pow(x, 2));
}
else if (x > 1 && x <= 4) 
{
    result = b*Math.Log(x)+Math.Pow(x, 3);
} 
else
{
    result = Math.Sqrt(Math.Pow(x,2)+a*b);
}

double z = x <= 1 ? (result = a * Math.Pow(Math.Cos(x), 2) - b * Math.Sin(Math.Pow(x, 2))) : (result = Math.Sqrt(Math.Pow(x, 2) + a * b));
double z2 = x > 1 && x <= 4 ? (result = b * Math.Log(x) + Math.Pow(x, 3)) : (result = 0);

Console.WriteLine($"If-else = {result}");
Console.WriteLine($"z and z1 = {z};{z2}");

