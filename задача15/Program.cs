// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Ведите цифру дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number == 6 || number == 7)
    {
    Сonsole.WriteLine("Да");
    }
else
    {
    Сonsole.WriteLine("НЕТ");
    }