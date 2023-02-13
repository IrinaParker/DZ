//Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).


Console.WriteLine("Введите целое число  ");
int number = int.Parse(Console.ReadLine()!);

if (number %2 == 0)
{
    Console.Write("Да");
}
else
{
   Console.Write("Нет"); 
}

