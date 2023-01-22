// Задача 10
Console.Write("Please enter 3 digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int ShowMidNum(int number)
{
    int remain = number % 100;
    return remain / 10;
}

Console.WriteLine(ShowMidNum(num));
// Задача 13
int number = ReadInt("Enter a number: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("There is no third figure in code, take it: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
// Задача 15
Console.Write("Please enter the number from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Yes");
    } 
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("Number is out of the range!!!");
}