// Задача 25
Console.Write("Enter the number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int AtoBDegree(int ac, int bc)
{
    int result = 1;
    for (int i = 0; i < bc; i++)
    {
        result = result * ac;
    }
    return result;
}

int aToBDegree = AtoBDegree(a, b);

Console.WriteLine($"{a} to the power of {b} equals {aToBDegree}.");
// Задача 27
Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());


int SumDigits(int num)
{
    int res = num % 10;
    if (num > 0)
    {
        for (int i = 0; num / 10 > 0; i++)
        {
            num = num / 10;
            res = res + num % 10;
        }
        return res;
    }
    else
    {
        Console.WriteLine("Please enter the positive number!");
        return 0;
    }
}

int sumDigits = SumDigits(n);

Console.WriteLine($"Sum of the digits of {n} equals {sumDigits}.");
// Задача 29
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int[] createArray = CreateArray(8, 0, 100);
PrintArray(createArray);