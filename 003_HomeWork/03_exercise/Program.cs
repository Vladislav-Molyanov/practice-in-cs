//Задача 23: Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void ConvertNumbersToCube (double arg)
{
    
    for(double i = 1;i <= arg;i++)
    {
        
       Console.Write($"{(int)Math.Pow(i, 3)},");
    }
    
}

Console.WriteLine("Введите число (N)");
double nums = double.Parse(Console.ReadLine());
nums = Math.Abs(nums);

ConvertNumbersToCube(nums);
