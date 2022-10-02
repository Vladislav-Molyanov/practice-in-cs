// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void OutputNaturalNumbers (int value)
{
    
    if(value > 0)
    {
        Console.Write($"{value},");
        OutputNaturalNumbers(value -1);
    }
    if (value < 0)
    {
        Console.Write($"{value},");
        OutputNaturalNumbers(value + 1);
    }
    
}
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("");
OutputNaturalNumbers(number);