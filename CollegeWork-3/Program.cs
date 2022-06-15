Console.WriteLine("Введите имя 1 ученика: ");
string? name1 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson1 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите имя 2 ученика: ");
string? name2 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson2 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите имя 3 ученика: ");
string? name3 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson3 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите имя 4 ученика: ");
string? name4 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson4 =  Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите имя 5 ученика: ");
string? name5 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson5 =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите имя 6 ученика: ");
string? name6 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson6 =  Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите имя 7 ученика: ");
string? name7 = Console.ReadLine();
Console.WriteLine("Возраст: ");
int lesson7 =  Convert.ToInt32(Console.ReadLine());



Console.WriteLine("| \t Фамилия И.О \t  Возраст \t |");
Console.WriteLine($"| \t {name1} \t\t \t {lesson1} \t |");
Console.WriteLine($"| \t {name2} \t\t \t {lesson2} \t |");
Console.WriteLine($"| \t {name3} \t\t \t {lesson3} \t |");
Console.WriteLine($"| \t {name4} \t\t \t {lesson4} \t |");
Console.WriteLine($"| \t {name5} \t\t \t {lesson5} \t |");
Console.WriteLine($"| \t {name6} \t\t \t {lesson6} \t |");
Console.WriteLine($"| \t {name7} \t\t \t {lesson7} \t |");

int res = lesson1+lesson2+lesson3+lesson4+lesson5+lesson6+lesson7;

Console.WriteLine($"Сумма возрастов: {lesson1}+{lesson2}+{lesson3}+{lesson4}+{lesson5}+{lesson6}+{lesson7} = {res}");