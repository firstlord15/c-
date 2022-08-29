// 7 вариант

//Console.WriteLine("Введите x:");
//double x = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Введите a:");
//double a = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Введите b:");
//double b = Convert.ToDouble(Console.ReadLine());

//double result = 0;

//if (a <= 0 || x <= 0)
//{
//    Console.WriteLine("Значение x или a не могут принять значение 0 и меньше");
//}
//else
//{
//    if (x > 3)
//    {
//        result = (a + x) * Math.Atan(a * x) * Math.Sqrt(x * a);
//        Console.WriteLine($"Ответ = {result}");
//    }
//    else
//    {
//        result = Math.Pow(Math.Cos(b + Math.Pow(x, 3)), 2) / Math.Pow(a * x, 2);
//        Console.WriteLine($"Ответ = {result}");
//    }
//}


// Ильюхин

//Console.Write("X:");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.Write("A:");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.Write("B:");
//double b = Convert.ToDouble(Console.ReadLine());


//double y;
//if (Math.Log(b + Math.Abs(x), Math.Exp(1)) <= 0)
//{
//    Console.WriteLine("b не может быть равен меньше -1");
//}
//else
//{
//    if (x <= -4)
//    {
//        y = a + (1 / Math.Sqrt(Math.Pow(x, 2) + 1));
//    }
//    else
//    {
//        y = Math.Log(b + Math.Abs(x), Math.Exp(1));
//    }

//    Console.WriteLine(y);
//}

// Атая


Console.WriteLine("Введите x:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите a:");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b:");
double b = Convert.ToDouble(Console.ReadLine());

double z;

if (x >= 1)
{
    z = Math.Sqrt(Math.Pow(a+x, 3));
}
else
{
    z = Math.Pow(Math.Exp(1), b*x-2);
}

Console.WriteLine(z);