//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. Решить задачу с использованием методов.

void exponentiation (int argA, int argB)
{   
    
    int result = (int)Math.Pow(Math.Abs(argA),Math.Abs(argB));
    
    Console.WriteLine($"{result}");
}

Console.WriteLine("Введите два числа");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
exponentiation(numA,numB);