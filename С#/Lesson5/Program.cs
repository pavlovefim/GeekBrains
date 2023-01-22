﻿// Задача 34
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

int PosEven(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        counter++;
    }
    return counter;
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

int[] array = CreateArray(10, 100, 1000);
PrintArray(array);
Console.WriteLine();
int posEven = PosEven(array);
Console.WriteLine(posEven);
// Задача 36
int[] array = {2, 6, 4, 8, 9, 4, 3, 7, 12, 6, 3, 5};

int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int oddSum = OddIndexSum(array);
// Задача 38
// // Random random = new Random();
// // double n = random.NextDouble()*100;
// // Console.WriteLine(Math.Round(n, 2));

double[] CreateDoubleArray(int size, int max, int roundTo)
{
    Random random = new Random();
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(random.NextDouble()*max, roundTo);
    }
    return arr;
}

double[] MinMax(double[] arr)
{
    double[] res = new double[2];
    
    res[1] = arr[0]; // max
    for (int i = 0; i < arr.Length; i++)
    {
        if(res[1] > arr[i]) continue;
        else res[1] = arr[i];
    }
    res[0] = arr[0]; // min
    for (int i = 0; i < arr.Length; i++)
    {
        if(res[0] < arr[i]) continue;
        else res[0] = arr[i];
    }
    return res;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

double[] array = CreateDoubleArray(10, 100, 2);
PrintArray(array);
double[] minMax = MinMax(array);
Console.WriteLine();
PrintArray(minMax);
double maxMinDiff = Math.Round(minMax[1] - minMax[0], 2);
Console.Write(" -> " + maxMinDiff);
