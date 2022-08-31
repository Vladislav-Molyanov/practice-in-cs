// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
N = Math.Abs(N);
int i = 2;

while(i <= N) 
{
    Console.Write($"{i},");
    i+=2;
}