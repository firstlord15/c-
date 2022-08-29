string? line, line2, line3, line4, line5;
int n = 0, x = 0, x2 = 0, x3 = 0, sn = 0;
bool isNum = true;

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите размер списка: ");
    Console.ForegroundColor = ConsoleColor.White;
    line = Console.ReadLine();

    isNum = int.TryParse(line, out n);

    if (isNum)
    {
        n = Convert.ToInt32(line);
    } else if (line.Trim() == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы ничего не ввели");
        Console.ForegroundColor = ConsoleColor.White;   
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вводить можно только цифры!");
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (isNum == false);

int[] list;
list = new int[n];

for (int i = 0; n > i; i++)
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Введите [{i}] элемент: ");
        Console.ForegroundColor = ConsoleColor.White;
        line2 = Console.ReadLine();

        isNum = int.TryParse(line2, out x);

        if (isNum)
        {
            x = Convert.ToInt32(line2);
        }
        else if (line2.Trim() == "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вводить можно только цифры!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    } while (isNum == false);

    list[i] = x;
}


// Первый номер

/*
 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\t\t\t\t\t Первая программа --> Удаление нечетных элементов");
Console.ForegroundColor = ConsoleColor.White;

for (int i = 0; n > i; i++)
{
    if (list[i] % 2 != 0)
    {
        Console.Write($" {list[i]}");
        list[i] = 0;
    }
} 


for (int i = 0; n > i; i++)
{
    Console.Write($"{list[i]} ");
}

 
 */

/////////////////////// Второй

/*
 
 Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\t\t\t\t\t Втроая программа --> добавления");
Console.ForegroundColor = ConsoleColor.White;

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Введите ско-ко элемента: ");
    Console.ForegroundColor = ConsoleColor.White;
    line3 = Console.ReadLine();

    isNum = int.TryParse(line3, out x2);

    if (isNum)
    {
    
        if (x2 >= 0)
        {
            x2 = Convert.ToInt32(line3);
        }
        else if (x2 < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нельзя вводить отрицательное число!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else if (line3.Trim() == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы ничего не ввели");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (Convert.ToInt32(line3) < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Нельзя вводить отрицательное число!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вводить можно только цифры!");
        Console.ForegroundColor = ConsoleColor.White;
    }
} while (isNum == false || x2 < 0);

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Введите от какого элемента: ");
    Console.ForegroundColor = ConsoleColor.White;
    line4 = Console.ReadLine();

    isNum = int.TryParse(line4, out x3);

    if (isNum)
    {

        if (x3 >= 0)
        {
            x3 = Convert.ToInt32(line3);
        }
        else if (x3 < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нельзя вводить отрицательное число!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    else if (line4.Trim() == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы ничего не ввели");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (Convert.ToInt32(line4) < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Нельзя вводить отрицательное число!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вводить можно только цифры!");
        Console.ForegroundColor = ConsoleColor.White;
    }
} while (isNum == false || x3 < 0);

int[] Array;
int n2 = n + x2;
Array = new int[n2 * 2];

for (int i = 0; i < n; i++)
{
    if (i < x3)
    {
        Array[i] = list[i];
    }
    else if (i >= x3)
    {
        Array[i + x2] = list[i];
    }
}

for (int i = 0; i < n2; i++)
{
    if (i >= x3 && i < x3+x2)
    {
        do
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Введите [{i}] элемент: ");
            Console.ForegroundColor = ConsoleColor.White;
            line5 = Console.ReadLine();

            isNum = int.TryParse(line5, out sn);

            if (isNum)
            {
                sn = Convert.ToInt32(line5);
            }
            else if (line5.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ничего не ввели");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Convert.ToInt32(line3) < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нельзя вводить отрицательное число!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вводить можно только цифры!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (isNum == false);

        Array[i] = sn;
    }
}

for (int i = 0; n2 > i; i++)
{
    Console.Write($"{Array[i]} ");
}

 
 */

/////////////////////// Третий


/*
 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\t\t\t\t\t Третья программа --> Сортировка (Сначала -, потом +)");
Console.ForegroundColor = ConsoleColor.White;


int temp;

for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (list[i] > list[j])
        {
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}


for (int i = 0; i < n; i++)
{
    Console.Write($" {list[i]}");
}


*/

/////////////////////////// Четвертый 

/*
 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\t\t\t\t\t\t Четвертая программа --> Поиск элемента");
Console.ForegroundColor = ConsoleColor.White;
 
 int w4 = 0;
string linew4;

do
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Введите элемент, который вы ищите: ");
    Console.ForegroundColor = ConsoleColor.White;
    linew4 = Console.ReadLine();

    isNum = int.TryParse(linew4, out w4);

    if (isNum)
    {
        w4 = Convert.ToInt32(linew4);
    }
    else if (linew4.Trim() == "")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вы ничего не ввели");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Вводить можно только цифры!");
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (isNum == false);

for (int i = 0; i < n; i++)
{
    if (list[i] == w4)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Индекс элемента {w4} = [{i}]");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
 

 */
