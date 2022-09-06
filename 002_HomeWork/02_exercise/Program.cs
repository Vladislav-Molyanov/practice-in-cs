//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите натуральное число");
string numStr = Console.ReadLine();

PrintThirdDigit(numStr);
void PrintThirdDigit(string arg) 
{
    if(arg.Length < 3) 
        {
            Console.WriteLine("Третьей цифры нет");
        }
    else 
    {
       Console.WriteLine(arg[2]);
    }
}