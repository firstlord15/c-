Console.WriteLine("Введите число");
string? n = Console.ReadLine();
int num = Convert.ToInt32(n);

int size = n.Length;
int sum = 0;

int[] nums = new int[size];
nums[0] = num;

for (int i = 0; i < size; i++)
{
    if (i != 0)
    {
        nums[i] = nums[i - 1] / 10;
    }
}

for (int i = 0; i < size; i++)
{
    if (i != size-1)
    {
        nums[i] = nums[i] % 10;
        // находим sum
        if (i != 0 && i != size - 1)
        {
            sum += nums[i];
        }
    }
}

for (int i = 0; i < size; ++i)
{
    Console.WriteLine($"nums[{i}] = {nums[i]}");
}

Console.WriteLine($"sum = {sum}");