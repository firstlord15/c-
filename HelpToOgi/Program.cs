/*
 
int a,b,h;
double x,y;

Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите h: ");
h = Convert.ToInt32(Console.ReadLine());

x = a;

while (x >= a && x < b)
{
    y = Math.Pow((x + 2), 3);
    Console.WriteLine(y);

    x = x + h;
}
 

 */

/*
double A, B, C;
int years = 0;

Console.Write("Введите сумму: ");
A = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите % начисления: ");
B = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите проходную сумму: ");
C = Convert.ToDouble(Console.ReadLine());

while (A <= C)
{
    A = A + (A / 100 * B);

    years++;
}

Console.WriteLine($"Через {years} лет");
*/

/*

int x = 10, x1 = 0, y = 0;

while (x < 100 && x >= 10) 
{
    y = x + x1;
    x++;

    Console.WriteLine(y);

    x1 = y;
}

Console.WriteLine($"y = {y}"); 

 */


/*
 
int x = 100;
int firse, third;

while (x >= 100 && x < 1000)
{
    firse = x / 10;
    third = x % 10;

    if (third != 0)
    {
        if (Math.Pow(firse, 2) - Math.Pow(third, 2) > 0)
        {
            Console.WriteLine(x);
        }
    }

    x++;
}
 
 */