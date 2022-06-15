using System;
using static System.Console;
using System.IO;

StreamReader sr = new StreamReader("test.txt");
string s = sr.ReadToEnd();

s = s.Replace("А", "Я");
Console.WriteLine(s);

StreamWriter F = new StreamWriter("answer.txt");
F.Write(s);
F.Close();