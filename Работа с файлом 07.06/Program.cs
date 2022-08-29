// using System;
// using System.IO;

// FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

// for (int i = 1; i < 21; i++)
//     F.WriteByte((byte)i);
// F.Position = 0;

// for (int i = 0; i < 21; i++)
//     Console.Write(F.ReadByte() + " ");

// F.Close();
// Console.ReadKey();

// первая

// using System;
// using System.IO;

// Console.WriteLine("Введите размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());


// int[] list = new int[n];
// int[] list2 = new int[n];
// Random rn = new Random();


// for (int i = 0; i < n; i++)
// {
// 	list[i] = rn.Next(-20, 20);
// }
// int col = 0;
// for (int i = 0; i < n; i++)
// {
// 	if (list[i] >= 0)
//     {
// 		list2[col] = list[i];
// 		col++;
// 	}
// }

// for (int i = 0; i < n; i++)
// {
// 	Console.Write($"Проверка: {list2[i]} ");
// }
// Console.WriteLine();


// FileStream F = new FileStream("Massiv.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
// FileStream F2 = new FileStream("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

// for (int i = 0; i < n; i++) 
// {
// 	F.WriteByte((byte)list[i]);
// }
// F.Position = 0;

// for (int i = 0; i < col; i++)
// {
// 	F2.WriteByte((byte)list2[i]);
// }
// F.Position = 0;

// for (int i = 0; i < n; i++)
// {
// 	Console.ForegroundColor = ConsoleColor.Cyan;
//     Console.Write(F.ReadByte() + " ");
// 	Console.ForegroundColor = ConsoleColor.White;
// }
// Console.WriteLine();
// for (int i = 0; i < col; i++)
// {
// 	Console.ForegroundColor = ConsoleColor.Magenta;
//     Console.Write(F2.ReadByte() + " ");
// 	Console.ForegroundColor = ConsoleColor.White;
// }

// F.Close();
// F2.Close();
// Console.ReadKey();

// Второе

using System;
using System.IO;

