// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CalcFunctionAccerman (int argM, int argN)
{       
    if (argM == 0) return argN + 1;
    if (argM > 0 && argN == 0) return CalcFunctionAccerman(argM - 1, 1);
    if (argM > 0 && argN > 0) return CalcFunctionAccerman(argM - 1, CalcFunctionAccerman(argM, argN - 1));
    
    return argN + 1;
            
}

            
           

Console.WriteLine("Введите значение m");
int valueM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение n");
int valueN = int.Parse(Console.ReadLine());

int AccerNum = CalcFunctionAccerman(valueM,valueN);
Console.WriteLine(AccerNum);