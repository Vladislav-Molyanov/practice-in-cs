//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели в виде числа.");
int num = Convert.ToInt32(Console.ReadLine());


void CheckDayWeek (int arg) 
{
    if(arg > 0 && arg < 6)
    {
        Console.WriteLine($"{arg}: это будний день");
    }

    else if (arg > 5 && arg < 8) 
    {
        Console.WriteLine($"{arg}: это выходной день");
    }
    
    else
    {
        Console.WriteLine("Вы ввели число, несоответствующее дню недели");
    }

}

CheckDayWeek(num);