Console.WriteLine("введите трехзначное число");
int num = int.Parse(Console.ReadLine());

int result = FindSecondDigit(num);
Console.WriteLine(result);

int FindSecondDigit(int arg)
{
   return (arg / 10) % 10;
    
}



