// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Примеры:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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


int FindSumElementPositions(int [] arr) 
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if ((i+1) % 2 == 0) sum = sum + arr[i];
    }
    return sum;
}

Console.WriteLine("Задайте размер массива");
int sizeArr = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте значение с которого начать интервал случайных чисел");
int initialInterval = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте значение на котором закончить интервал случайных чисел");
int endInterval = int.Parse(Console.ReadLine());


int[] array = GetArray(sizeArr,initialInterval,endInterval);
Console.Write("[");
for(int i = 0; i < array.Length; i++)
{   
    
    Console.Write($"{array[i]}");
    if(i == array.Length -1)
    {
        break;
    }
    Console.Write(",");
}
Console.WriteLine("]");

int sumElement = FindSumElementPositions(array);
Console.WriteLine(sumElement);