
bool CheckPalindrome (string arg)
{
    for(int i = 0; i < arg.Length / 2; i++) 
    {
        if(arg[i] != arg[arg.Length-1-i])
        { 
            return false;
        }
        
    }
    return true;


}

Console.WriteLine("Введите пятизначное число");
int nums = int.Parse(Console.ReadLine());
nums = Math.Abs(nums);

string convNumStr = Convert.ToString(nums);

if(CheckPalindrome(convNumStr))
{
    Console.WriteLine($"Число {convNumStr} является палиндромом");
}
else
{
    Console.WriteLine($"Число {convNumStr} не является палиндромом");
}

