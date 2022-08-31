// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


Console.WriteLine("Введите первое число");
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numTwo = int.Parse(Console.ReadLine());

if (numOne > numTwo) 
{
    Console.WriteLine($"max = {numOne}");
}
else 
{
    Console.WriteLine($"max = {numTwo}");
}
