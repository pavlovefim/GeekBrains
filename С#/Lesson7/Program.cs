// Задача 47
double[,] CreateMatrixRndInt(int row, int col)
{
    double[,] matr = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(rnd.NextDouble() * rnd.Next(-10, 10), 1);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            else Console.Write($"{matrix[i,j], 4}");
        }
        Console.WriteLine("]");
    }
}

double[,] matrix = CreateMatrixRndInt(5,4);
PrintMatrix(matrix);
// Задача 50
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[,] matrix = CreateMatrixRndInt(5, 6, -10, 10);
PrintMatrix(matrix);

Console.WriteLine("Please enter the coordinates: ");
Console.Write("Row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Column: ");
int col = Convert.ToInt32(Console.ReadLine());

void MatrixIndexCheck(int[,] matr, int row_m, int col_m)
{
    if (row_m - 1 < matr.GetLength(0)
    && col_m - 1 < matr.GetLength(1))
    {
        Console.WriteLine(matr[row_m - 1, col_m - 1]);
    }
    else
    {
        Console.WriteLine("There is no such element in this matrix!");
    }
}

MatrixIndexCheck(matrix, row, col);
// Задача 52
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i],4}, ");
//         else Console.Write($"{arr[i],4} ");
//     }
//     Console.WriteLine("]");
// }

void ColAvarage(int[,] matr)
{
    Console.Write("[");
    for (int i = 0; i < matr.GetLength(1); i++)
    {
    double result = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            result += matr[j,i];
        }
    if (i < matr.GetLength(1) -1 ) Console.Write(result / matr.GetLength(0) + ", ");
    else Console.Write(result / matr.GetLength(0) + "]");
    }
}


int[,] matrix = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(matrix);
Console.Write("Avarage of each column equals to: ");
ColAvarage(matrix);