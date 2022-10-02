// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void CaclSumNaturalElements (int initialValue, int finalValue)
{
    int sum = 0;
    for (int i = initialValue; i <= finalValue; i++)   
    {
        sum += i;
    }
    Console.WriteLine(sum);
}


Console.WriteLine("Введите число M");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = int.Parse(Console.ReadLine());
CaclSumNaturalElements(numberM,numberN);