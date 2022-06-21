Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Random rn = new Random();
int[] Array = new int[n];

static void print(int[] predl)
{
    for (int i = 0; i < predl.Length; i++)
    {
        Console.WriteLine($"[{i}] = {predl[i]}");
    }
}

static void vod(int[] predl)
{
    for (int i =0; i < predl.Length; i++)
    {
        Console.Write($"[{i}] = ");
        predl[i] = Convert.ToInt32(Console.ReadLine());
    }
}

vod(Array);
Console.WriteLine();
Console.WriteLine("Array: ");
print(Array);

int x = 0;
for (int i = 0; i < n; i++)
{
    if (i % 3 == 0)
    {
        if (Array[i] < 0)
        {
            x++;
        }
    }
}

int[] Otrits = new int[x];

static void Do(int[] predl1, int[] predl2)
{
    int n = 0;
    for (int i = 0; i < predl1.Length; i++)
    {
        if (i % 3 == 0)
        {
            if (predl1[i] < 0)
            {
                predl2[n] = predl1[i];
                n++;
            }
        }
    }
}

Do(Array, Otrits);

Console.WriteLine();
Console.WriteLine("Otrits: ");
print(Otrits);