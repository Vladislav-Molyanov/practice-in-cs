//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int calcSumDigitsNumber (int num) 
{
    num = Math.Abs(num);
    string numStr = Convert.ToString(num);
    int result = 0;
    if (num > 0 )
    {
        for(int i = 0; i < numStr.Length; i++) 
    {
        result = result + (int)(numStr[i]-'0');
    }
    }
    return result;
}
    
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(calcSumDigitsNumber(num));
