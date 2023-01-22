// Задача 64
Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturanNumsToN(int num)
{
    if (num == 1)
    {
        Console.Write($"{num} ");
        return;
    }
    if (n > 1)
    {
        Console.Write($"{num}, ");
        NaturanNumsToN(num - 1);
    }
    else
    {
        Console.Write($"{num}, ");
        NaturanNumsToN(num + 1);
    }
}

NaturanNumsToN(n);

// Задача 66
Console.Write("Enter the value for M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value for N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumElement(int m1, int n1)
{
    int result = 0;
    if (n1 == m1)
    {
        return result + m1;
    }
    if (m1 > n1)
    {
        result += SumElement(m1 - 1, n1);
    }
    else
    {
        result += SumElement(m1 + 1, n1);
    }
    return result += m1;
}

int res = SumElement(m, n);
Console.WriteLine(res);

// Задача 68
Console.Write("Enter the value for m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value for n: ");
int n = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int m, int n)
{
    int res = 0;
    if (m == 0)
    {
        res = n+1;
        return res;
    }
    else if (m > 0 && n == 0)
    {
        res = AckermannFunction(m -1, 1);
        return res;
    }
    else if (m > 0 && n > 0)
    {
        res = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return res;
    }
    return res;
}
int result = AckermannFunction(m,n);
Console.WriteLine(result);