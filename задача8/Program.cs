// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Ведите целое положительное число n: ");
int N=int.Parse(Console.ReadLine()!);

int K = 2;

while (K <=N)
{
       Console.Write($"{K} ");
K+=2;
}