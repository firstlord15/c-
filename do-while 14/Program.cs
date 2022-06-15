int s = 0, n;
string? str, str2;
bool isNum, isYN;

Console.WriteLine("Будете вносить данные? (y/n): ");
str = Console.ReadLine();

do
{
    Console.WriteLine("Введите длинну тоннеля за этот месяц: ");
    str2 = Console.ReadLine();
    isNum = int.TryParse(str2, out n);
    

    if (isNum == false)
    {
        if (str2 == "" || str2 == " ")
        {
            Console.WriteLine("Вы ничего не ввели");
        }
        else
        {
            Console.WriteLine("Вы вели строку");
        }
    }
    else
    {
        if (n < 0)
        {
            Console.WriteLine("Вы вели отрицательное число");
        } 
        else
        {
            n = Convert.ToInt32(str2);
        }
    }

    if (str == "y")
    {
        isYN = true;
    }
    else if\\
    {
        isYN = false;
    }
    s += n;

    Console.WriteLine("Будете вносить данные? (y/n): ");
    str = Console.ReadLine();
}
while (str == "y" && );