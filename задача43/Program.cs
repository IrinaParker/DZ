﻿// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine ("Введите коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
Console.WriteLine (x);
double y = k1*x+b1;
Console.WriteLine ("Точка пересечения 2-х прямых с заданными коэффициентами k и b имеет координаты:  ("+x+","+y+")");