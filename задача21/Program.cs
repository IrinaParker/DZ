// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84


Console.WriteLine("Введите координаты точки А, х1: ");
int x1= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки А, y1: ");
int y1= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки А, w1: ");
int w1= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B, х2: ");
int x2= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B, y2: ");
int y2= int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B, w2: ");
int w2= int.Parse(Console.ReadLine()!);

double S = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(w1-w2, 2));

Console.WriteLine($"Расстояние между точками в А и B в ЗD пространстве: {S:f2}");
