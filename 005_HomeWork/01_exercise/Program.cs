// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример : [345, 897, 568, 234] -> 2

int[] GetArray(int size, int startValue, int endValue)
{   
    var array = new int[size];

    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue,endValue + 1);
    }
    return array;
}

int CalcEvenNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0 )
        {
            count = count +1;
        }
    }
    return count;
}

Console.WriteLine("Задайте размер массива");
int sizeArr = int.Parse(Console.ReadLine());
int[] array = GetArray(sizeArr,100,1000);
int count = CalcEvenNumbers(array);
Console.WriteLine(count);