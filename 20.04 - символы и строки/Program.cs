int c = 48;
int n = 6;
char code;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < n; j++)
    {
        code = (char)c;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(code + " ");
        Console.ForegroundColor= ConsoleColor.White;
        c++;
    }
    n--;
    c = 48;
    Console.WriteLine();
}