// Первое

/*
 
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

double f = Math.Sin(Math.Log10(x)) - Math.Cos(Math.Log10(x));
double g = Math.Tan(x/2)-Math.Tan(1/(x / 2));

Console.WriteLine(f);
Console.WriteLine(g);
 
 */


// Второе

/*
 
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((a / 100) + (a / 10 % 10) + (a % 10));

 */



// Третье

/*
 
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());

double x = 2.92;

double y;


if (x <= 1)
{
    y = 1 / (Math.Pow(a, 2) + Math.Pow(x, 2));
} 
else
{
    y = b * Math.Log10(x);
}

Console.WriteLine(y);
 
 */

// Четвертое 


/*
 
Console.WriteLine("Введтите E");
double E = Convert.ToDouble(Console.ReadLine());

double a = 0, S = E, S1 = 0;
int n = 1;

while (Math.Abs(S - S1) >= E)
{
    a = (double) 1 / (3 * n);
    Console.WriteLine($"1 / {3 * n}");
    S = S1;
    S1 += a;
    n++;
}
Console.WriteLine(S); 

 */

// Пятое

/*
 
string? a, b = "y";
bool isNum = false;
int n = 0, answer = 0;

while (b != "no" || b != "n")
{
    do
    {
        Console.WriteLine("Введите минуты");
        a = Console.ReadLine();

        isNum = int.TryParse(a, out n);

        if (isNum)
        {

            if (Convert.ToInt32(a) < 0)
            {
                Console.WriteLine("Надо вводить положительное число!");
                isNum = false;
            }
            else
            {
                n = Convert.ToInt32(a);
            }
        }
        else if (isNum == false)
        {
            Console.WriteLine("Надо вводить число!");
        }
    } while (isNum == false);

    answer += n;
    Console.WriteLine("Хотите ввести минуты?");
    b = Console.ReadLine();

    if (b == "n" || b == "no")
    {
        break;
    }
}

Console.WriteLine(answer + " минут"); 

 */

// шестое (не доделал)




/*
 
string? a = "", b = "", d = "";
double a1 = 0, b1 = 0, d1 = 0, sum = 0;
bool isNum1, isNum2, isNum3;

do
{
   Console.Write("Введите a: ");
   a = Console.ReadLine();

   isNum1 = double.TryParse(a, out sum);

   if (isNum1 == false)
   {
        Console.WriteLine("Надо вводить число!");
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
        Console.WriteLine("Надо вводить число!");
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
        Console.WriteLine("Надо вводить число!");
    }
    else
    {
       d1 = Convert.ToDouble(d);
    }
}

while (isNum3 == false);


Console.WriteLine("\t x \t\t f \t");
Console.WriteLine("___________________________________________");

double fun = 0;

for (double i = a1; i <= b1; i += d1)
{
    fun = 5 * Math.Pow(Math.Exp(1), -0.5 * i) * Math.Sin(Math.PI*i);

    Console.WriteLine($"\t {i} \t | \t {fun}");
    Console.WriteLine("___________________________________________");

    Console.WriteLine(Math.Truncate(fun));

    if (Math.Truncate(fun) % 2 == 0)
    {
        sum *= fun;
    }
}
Console.WriteLine();


Console.WriteLine($"Ответ = {sum}"); 

 */





// седьмое

/*
 
string? a;
int N, x, y = 1, x1;
int sum = 1, max = -100;
bool isNum1;
do
{
    Console.Write("Введите N: ");
    a = Console.ReadLine();

    isNum1 = int.TryParse(a, out N);

    if (isNum1 == false)
    {
        Console.WriteLine("Надо вводить число!");
    }
    else
    {
        N = Convert.ToInt32(a);
    }
}
while (isNum1 == false);

while (y <= N)
{
    Console.Write($"Введите x{y}: ");
    x = Convert.ToInt32(Console.ReadLine());

    if (x % 2 != 0)
    {
        sum *= x;
    }

    if (x < 0)
    {
        if (x > max)
        {
            max = x;
        }
    }
    y++;
}

Console.WriteLine($"Ответ = {sum - max}");
 
 */

// восьмое 

// Описание: Сначала создаем переменые a = 3 и b = 7. Потом мы создаем условие,
// если сумма a и b больше 10, то d = a+b, если же нет, то d = их произведению. 
// В конце выводим d.

// правильный ответ если a+b больше 10 --> d = 10
// правильный ответ если a+b не больше 10 --> d = 21

/*
 
 int d = 0, a = 3, b = 7;

if (a + b > 10)
{
    d = a + b;
} 
else
{
    d = b * a;
}
Console.WriteLine($"d = {d}");
 
 */

// Девятое - 1

/*
 
string? number;
Console.WriteLine("Введите цифру");
number = Console.ReadLine();



switch (number)
{
    case "1":
        Console.WriteLine("A");
        break;
    case "2":
        Console.WriteLine("B");
        break;
    case "3":
        Console.WriteLine("C");
        break;
    case "4":
        Console.WriteLine("D");
        break;
    case "5":
        Console.WriteLine("E");
        break;
    case "6":
        Console.WriteLine("F");
        break;
    case "7":
        Console.WriteLine("G");
        break;
    case "8":
        Console.WriteLine("H");
        break;
    case "9":
        Console.WriteLine("I");
        break;
    case "0":
        Console.WriteLine("J");
        break;
}
 
 */

// девть - 2

/*
 
int days = 0;

Console.WriteLine("Какой сегодня день?");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Какой месяц?");
int b = Convert.ToInt32(Console.ReadLine());

switch (b)
{
    case 1: case 5: case 7: case 9: case 11:
        days = 31;
        break;
    case 2: case 4: case 6: case 8: case 10: case 12:
        days = 30;
        break;
    case 3:
        days = 28;
        break;
}

Console.WriteLine($"До конца месяца осталось {days - a} дней");
 
 */

// Девятый - 3

/*
 
Console.WriteLine("Какой у вас вагон?");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 10: case 11: case 12: case 13: case 14: case 15: case 16: case 17:
        Console.WriteLine("Купейный вагон");
        break;
    default:
        Console.WriteLine("Плацкартный вагон");
        break;
}

 */

// Десятый 
/*
int x = 0;
Console.WriteLine("Размер массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите [{i}] элемент");
    x = Convert.ToInt32(Console.ReadLine());
    arr[i] = x;
}

Console.WriteLine("Ответ");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

Console.WriteLine("На сколько элементов на лево подвинуть?");
int skoko = Convert.ToInt32(Console.ReadLine());

int[] arr4 = new int[n + skoko];

for (int i = 0; i < n; i++)
{
    arr4[i] = arr[i];
}

Console.WriteLine("Ответ");
for (int i = 0; i < n+skoko; i++)
{
    Console.Write(arr4[i] + " ");
}
Console.WriteLine();

// четвертая часть

Console.WriteLine("Какой элемент вы хотите найти?");
int search = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n+skoko; i++)
{
    if (arr4[i] == search)
    {
        Console.WriteLine($"Индекс элемента `{search}` = [{i}]");
    }
}

*/

// Одиннадцатый  

/*
 
Random rn = new Random();
Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

double sred = 0;
double col = 0;

int[,] arr = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = rn.Next(1, 9);
    }
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; ++i)
{
    for (int j = 0;j < m; j++)
    {
        if (arr[i, j] % 2 != 0)
        {
            sred += arr[i, j];
            col++;
        }
    }
}
Console.WriteLine();

if (col == 0)
{
    Console.WriteLine($"Таких значений нет!");
} else
{
    Console.WriteLine($"Ответ = {sred / col}");
}

 */

// Двенадцатый

/*
 
Random rn = new Random();
int col = 0;
int[,] arr = new int[5, 6];

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        arr[i, j] = rn.Next(-10, 10);
    }
}
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 6; j++)
    {
        if (arr[i, j] < 0)
        {
            if (arr[i, j] < 0)
            {
                col++;
            }
        }
    }
    Console.WriteLine($" {i} строке = {col}");
    col = 0;
}
Console.WriteLine(); 

 */

// Тренадцатый (вроде доделал)

/*
 
// Вот это я делал дольше всего

Console.Write("Введите m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n = ");
int n = Convert.ToInt32(Console.ReadLine());

Random rn = new Random();

int[,] arr = new int[n, m];
int[,] arr2 = new int[n+1, m];
int[] second = new int[n];

// создание списка

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = rn.Next(0, 10);
    }
}
Console.WriteLine();

// Выводим список 

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(arr[i, j] + "   ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// забираем вторую строчку списка

for (int i = 0; i < m; i++)
{
    second[i] = arr[1, i];
}

// спрашиваем интервал

Console.Write("Введите A = ");
double A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите B = ");
double B = Convert.ToInt32(Console.ReadLine());

// понимаем куда вводить вторую строку

int place = -1;

if (A == B) // два if нужно в случае если A и B равны
{
    for (int i = 0; i < n; i++)
    {
        if (place == -1) 

        {
            for (int j = 0; j < m; j++)
            {
                if (arr[i, j] == A)
                {
                    place = i;
                }
            }
            Console.WriteLine(place);
        }
        else
        {
            break;
        }
    }
} else
{
    for (int i = 0; i < n; i++)
    {
        if (place == -1)
        {
            for (int j = 0; j < m; j++)
            {
                if (arr[i, j] >= A && arr[i, j] < B)
                {
                    place = i;
                }
            }
            Console.WriteLine(place);
        }
        else
        {
            break;
        }
    }
}


if (place == 0)
{
    for (int i = 0; i < n; i++)
    {
        for (int k = 0; k < m; k++)
        {
            arr2[i, k] = arr[i, k];
        }
    }
}
else
{
    for (int i = 0; i < n + 1; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (i == place + 1)
            {
                arr2[i, j] = second[j];
            }
            else if (i < place + 1 && i != 1)
            {
                arr2[i, j] = arr[i, j];
            }
            else if (i > place + 1 && i != 1)
            {
                arr2[i, j] = arr[i - 1, j];
            }
        }
    }
}


for (int i = 0; i < n+1; ++i)
{
    for (int j = 0; j < m; ++j)
    {
        Console.Write(arr2[i, j] + "   ");
    }
    Console.WriteLine();
}


 */

// Лаборатоная на одн.масссив...

/*
 
Random rn = new Random();

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите эелемент {i}");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int last = 0;
int first = 0;

for (int i = 0; i < n; i++)
{
    if (arr[i] == 0)
    {
        last = i;
    }
}

for (int i = 0; i < n; i++)
{
    if (arr[i] == 0)
    {
        first = i;
        break;
    }
}

int sum = 0;
int pro = 1;

for (int i = 0; i < n; i++)
{
    if (i > first && i < last)
    {
        sum += arr[i];
    }

    if (i % 2 == 0)
    {
        pro = pro * arr[i];
    }
}

Console.WriteLine("Сумма = "+sum);
Console.WriteLine("Произведение = " + pro); 

 */

// кт 

/*
 
Console.WriteLine("Хотите ли вы ввести еще точку? y/n");
string? ans = Console.ReadLine();
int z = 0, z1 = 0;

while (ans == "y")
{
    Console.WriteLine("Введите коoрдинату Х: ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите коoрдинату Y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    if (x > 0 && y < 0)
    {
        if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 9)
        {
            Console.WriteLine("Точка принадлежит области");
            z++;
        }
        else
        {
            Console.WriteLine("Точка не принадлежит области");
            z1++;
        }
    } else if (y < 0 && x > 0)
    {
        if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
        {
            Console.WriteLine("Точка принадлежит области");
            z++;
        }
        else
        {
            Console.WriteLine("Точка не принадлежит области");
            z1++;
        }
    } else
    {
        Console.WriteLine("Точка не принадлежит области");
        z++;
    }
    Console.WriteLine("Хотите ли вы ввести еще точку? y = да, n = нет");
    ans = Console.ReadLine();
}

Console.WriteLine("Кол-во точек, лежащий в области: " + z);
Console.WriteLine("Кол-во точек, не лежащий в области: " + z1);

 */

