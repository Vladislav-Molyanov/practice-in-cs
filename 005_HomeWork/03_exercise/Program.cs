// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// Пример:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] GetArray (int size, int startValue, int endValue)
{
    var arr = new int[size];

    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(startValue,endValue);
    }
    return arr;
}

int[] CaclSumElements (int[] arr)
{   
    int size = arr.Length / 2;

    if(arr.Length % 2 == 1)
    {
      size++;
    }

    int [] array = new int[size];

    for (int i = 0; i < arr.Length / 2; i++)
    {       
        
        array[i] = arr[i] * arr[arr.Length - i - 1];
        
    }

    if (arr.Length % 2 == 1) 
    {
        array[array.Length - 1] = arr[(arr.Length/2) ];
    }
    return array;
}

Console.WriteLine("Задайте размер массива");
int sizeArr = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте значение с которого начать интервал случайных чисел");
int initialInterval = int.Parse(Console.ReadLine());

Console.WriteLine("Задайте значение на котором закончить интервал случайных чисел");
int endInterval = int.Parse(Console.ReadLine());


int[] newArray = GetArray(sizeArr,initialInterval,endInterval);

Console.WriteLine("Вывод нового массива: [" + string.Join(", ", newArray) + "]");

int[] nextArray = CaclSumElements(newArray);


Console.WriteLine("Вывод нового массива: [" + string.Join(", ", nextArray) + "]");
