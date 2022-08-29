using System;
class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем данные
        Console.WriteLine("Введите высоту большого прямоугольного параллелепипеда: ");
        int H1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину большого прямоугольного параллелепипеда: ");
        int A1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ширину прямоугольных параллелепипедов: ");
        int A2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите высоту маленького прямоугольного параллелепипеда: ");
        int H2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите длину маленького прямоугольного параллелепипеда: ");
        int B1 = Convert.ToInt32(Console.ReadLine());

        // Вычисляем Объем
        int V1 = H1*A1*A2;
        int V2 = H2*B1*A2;

        // Вычисляем Площадь
        int S1 = A1*H1*2 + A2*H1*2 + A1*A2 + A1*A2 - B1*A2;
        int S2 = H2*A2*2 + B1*A2 + H2*B1*2;

        Console.WriteLine($"Объем: {V1 + V2} см3");
        Console.WriteLine($"Площадь: {S1 + S2} см2");

        // находим боковые стороны с помощью Теорема Пифагора.
        double F1 = Math.Pow(H1+H2,2) + Math.Pow(B1, 2);
        // находим корень
        // Console.WriteLine(F1);
        double F2 = Math.Sqrt(F1);
        // Находим площадь
        // Console.WriteLine(F2);
        double S_S = A2*F2;

        Console.WriteLine($"Подсчет Площади прямоугольника в разрез = {Convert.ToInt32(S_S)} см2");
    }
}