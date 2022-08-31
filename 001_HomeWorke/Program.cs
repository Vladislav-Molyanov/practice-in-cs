// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


// Console.WriteLine("Введите первое число");
// int numOne = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int numTwo = int.Parse(Console.ReadLine());

// if (numOne > numTwo) 
// {
//     Console.WriteLine($"max = {numOne}");
// }
// else 
// {
//     Console.WriteLine($"max = {numTwo}");
// }


// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.


// Console.WriteLine("Введите первое число");
// int numOne = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int numTwo = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int numThree = int.Parse(Console.ReadLine());

// if (numOne > numTwo ) 
// {
//     Console.WriteLine($"max = {numOne}");
// }
// else if (numTwo > numThree)
// {
//     Console.WriteLine($"max = {numTwo}");
// }
// else 
// {
//     Console.WriteLine($"max = {numThree}");
// }



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int result = num % 2;
// if(result == 0) 
// {
//     Console.WriteLine("Да");
// }
// else 
// {
//     Console.WriteLine("Нет");
// }

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
    
