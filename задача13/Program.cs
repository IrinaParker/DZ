//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!);

if (number > 99)
{
    while(number > 999)
    {
        number /= 10;
    } 

    int result = number % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("нет");
}