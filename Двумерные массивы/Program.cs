int size, answer, result = 0;
bool isNum = true;
int colvo = 0;

string? line, line2;

do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Введите размер массива: ");
    line = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;

    isNum = int.TryParse(line, out size);

    if (isNum)
    {
        size = Convert.ToInt32(line);
    }
    else
    {
        if (line.Trim() == "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ничего не ввели!");
            Console.ForegroundColor= ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нельзя вводить ничего, кроме цифр!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

} while (isNum == false);

int[] list = new int[size];

for (int i = 0; i < size; i++)
{
    do
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"Введите [{i}]: ");
        Console.ForegroundColor = ConsoleColor.White;
        line2 = Console.ReadLine();

        isNum = int.TryParse(line2, out answer);

        if (isNum)
        {
            answer = Convert.ToInt32(line2);
        }
        else
        {
            if (line2.Trim() == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ничего не ввели!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нельзя вводить ничего, кроме цифр!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    } while (isNum == false);
    
    list[i] = answer;
}

for (int i = 0; i < list.Length; i++)
{
    if (list[i] % 2 == 0)
    {
        result += list[i];
        colvo++;
    }
}

Console.WriteLine("");

for (int i = 0; i < list.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write($"{list[i]} ");
    Console.ForegroundColor = ConsoleColor.White;
    if (i+2 > list.Length)
    {
        Console.WriteLine("");
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Результат = {result}");
Console.WriteLine($"Кол-во = {colvo}");
Console.ForegroundColor = ConsoleColor.White;