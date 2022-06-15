Console.Write("Кол-во предложений: ");
Console.ForegroundColor = ConsoleColor.Cyan;
int n = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();


string[] main = new string[n];
string[] sub = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i+1} предложение: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    main[i] = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();

Console.WriteLine("\t\t Вы написали");

for (int i = 0; i < n; i++)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(main[i]);
    Console.ForegroundColor = ConsoleColor.White;
}
Console.WriteLine();


Console.Write("Какое слово вы хотите удалить: ");
Console.ForegroundColor = ConsoleColor.Cyan;
string? delete = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();


for (int i = 0; i < n; i++)
{
    string[] slova = main[i].Split(' ');

    for (int j = 0; j < slova.Length; j++)
    {
        if (slova[j] != delete)
        {
            sub[i] = sub[i] + " " + slova[j];
        }
    }
    Console.WriteLine(sub[i]);
}
Console.WriteLine();