// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите число а: ");
int a= int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b= int.Parse(Console.ReadLine()!);

int max=a;

if (a> max) max =a;
if (b >max) max =b;
Console.WriteLine (max);
