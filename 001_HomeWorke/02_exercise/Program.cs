﻿// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число");
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numTwo = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numThree = int.Parse(Console.ReadLine());

if (numOne > numTwo ) 
{
    Console.WriteLine($"max = {numOne}");
}
else if (numTwo > numThree)
{
    Console.WriteLine($"max = {numTwo}");
}
else 
{
    Console.WriteLine($"max = {numThree}");
}

