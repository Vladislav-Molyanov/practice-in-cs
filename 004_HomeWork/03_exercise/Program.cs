//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//Элементы массива вводятся пользователем.

int [] array1 = new int[8];

for (int i = 0; i < array1.Length; i++ )
{
    Console.WriteLine($"Введите {i} элемент массива");
    array1[i] = int.Parse(Console.ReadLine());

}
Console.Write("[");
for(int i = 0; i < array1.Length; i++)
{   
    
    Console.Write($"{array1[i]}");
    if(i == array1.Length -1)
    {
        break;
    }
    Console.Write(",");
}
Console.WriteLine("]");
