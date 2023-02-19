//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


void Fillarray(int [] num)
{
    int length = num.Length;
    int index= 0;
    while (index < length)
    {
        num [index] = new Random().Next(1, 9);
        index++;
    }
}
void PrintArray(int[] number)
{
    int length= number.Length;
    int index= 0;
    Console.WriteLine("[");
    while(index < length)
    {
        Console.WriteLine(number[index]);
        if (index !=length-1)
        {
          Console.WriteLine(", ");
        }

        index++;
    }
    Console.WriteLine("]");
}
void ifprintarray(int[] number)
{
    int length = number. Length;
    int index= 0;
    while (index < length)
    {
        Console.WriteLine(number[index]);
        if (index != length - 1)
        {
            Console.WriteLine(", ");
        }
        index ++;
    }
}
int [] array=new int [8];

Fillarray(array);
ifprintarray(array);
Console.WriteLine("=> ");
PrintArray (array);

