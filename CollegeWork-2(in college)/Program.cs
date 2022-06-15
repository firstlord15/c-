﻿bool bl = true;
byte bt = 102;
char ch = 'А';
decimal de = 1.8m;
double db = 100;
float fl = 4.35f;
int n1 = 125; 
long b = 132;
object ob = "obj";
sbyte sb = -123;
short sh = 214;
string st = "str";
uint un = 251;
ulong ul = 121;
ushort us = 246;

Console.WriteLine("");
Console.WriteLine($"|\tКлючевое слово\tТип данных\tЧто Это?\tРазмер в байтах\t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   bool   \t {bl} \t System.Boolen \t структура\t {sizeof(bool)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   byte   \t {bt} \t System.Byte   \t структура\t {sizeof(byte)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   char   \t {ch} \t System.Char   \t структура\t {sizeof(char)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   decimal\t {de} \t System.Decimal\t структура\t {sizeof(decimal)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   double \t {db} \t System.Double \t структура\t {sizeof(double)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   float  \t {fl} \t System.Single \t структура\t {sizeof(float)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   int    \t {n1} \t System.Int32  \t структура\t {sizeof(int)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   long   \t {b}  \t System.Int64  \t структура\t {sizeof(long)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   object \t {ob} \t System.Object \t класс       \t - \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   sbyte  \t {sb} \t System.SByte  \t структура\t {sizeof(sbyte)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   short  \t {sh} \t System.Int16  \t структура\t {sizeof(short)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   string \t {st} \t System.String \t класс       \t - \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   uint   \t {un} \t System.UInt32 \t структура\t {sizeof(uint)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   ulong  \t {ul} \t System.UInt64 \t структура\t {sizeof(ulong)} \t|");
Console.WriteLine("|_______________________________________________________________________|");
Console.WriteLine($"|\t   ushort \t {us} \t System.UInt16 \t структура\t {sizeof(ushort)} \t|");
Console.WriteLine("|_______________________________________________________________________|");

int lenst = st.Length;
int lenob = ob.Length;
Console.WriteLine(lenst);
Console.WriteLine(lenob);