// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] GetArray (int size)
{
    var arr = new int[size];

   
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int  CalcNumbersMoreZero (int [] arg)
{
    int count = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if( arg[i] > 0)
        {
            count ++;
        }
        
    }
    return count;
}

Console.WriteLine("Введите количество элемментов в  массиве");
int num = int.Parse(Console.ReadLine());
int[] Array = GetArray(num);
Console.WriteLine("Массив  чисел: ["+ string.Join(",", Array) +"]");

int numCount = CalcNumbersMoreZero(Array);
Console.WriteLine($"Количество числе > 0 = {numCount}");