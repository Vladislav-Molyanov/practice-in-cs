// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int result = num % 2;
if(result == 0) 
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}