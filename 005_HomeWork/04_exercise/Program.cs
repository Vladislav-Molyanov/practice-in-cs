// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример:
// [3 7 22 2 78] -> 76

int [] GetArray (int size)
{
    var arr = new int[size];

    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(10,100);
    }
    return arr;
}

int FindMinNumber (int [] arr) 
{
    int min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

int FindMaxNumber (int [] arr) 
{
    int max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int CaclDifference (int Max, int Min)
{
    int sum;
    return  sum = Max - Min;
}
Console.WriteLine("Введите длину массива");
int sizeArray = int.Parse(Console.ReadLine());

int [] array = GetArray(sizeArray);
Console.WriteLine("Массив случайных чисел: ["+ string.Join(",", array) +"]");
int maxNum = FindMaxNumber(array); 
int minNum = FindMinNumber(array);
int diff = CaclDifference(maxNum,minNum);
Console.WriteLine($"Максимальное число в массиве = {maxNum}");
Console.WriteLine($"Минимальное число в массиве = {minNum}");
Console.WriteLine($"Разница максимального и минимального значений массива = {diff}");