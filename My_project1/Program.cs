// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// double result = Math.Pow(num, 3);
// Console.WriteLine($"Куб числа {num} = {result}");
// int result1 = num * num;
// Console.WriteLine($"Квадрат числа {num} = {result1}");

// //Задача №1.
// Console.WriteLine("Введите первое число");
// int numOne = int.Parse(Console.ReadLine()); 
// Console.WriteLine("Введите второе число");
// int numTwo = int.Parse(Console.ReadLine());

// if (numOne == numTwo * numTwo) 
// {
//     Console.WriteLine("Да, верно");
// }
// else
// {
//     Console.WriteLine("Ложно");
// }

// №2

// Console.WriteLine("Введите число");
// int number = int.Parse(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(number == 2) 
// {
//     Console.WriteLine("Вторник");
// }
// else if(number == 3) 
// {
//     Console.WriteLine("Среда");
// }
// else if(number == 4) 
// {
//     Console.WriteLine("Четверг");
// }
// else if(number == 5) 
// {
//     Console.WriteLine("Пятница");
// }
// else if(number == 6) 
// {
//     Console.WriteLine("Суббота");
// }
// else if(number == 7) 
// {
//     Console.WriteLine("Воскресенье");
// }
// else 
// {
//     Console.WriteLine("Это число не соотвествует, введите число от 1 до 7");
// }

//№3

Console.WriteLine("Введите число n");
int num = int.Parse(Console.ReadLine());

int i = Math.Abs(num) * -1;

while (i <= num) 
{
    Console.Write($"{i},");
    i++;
}



