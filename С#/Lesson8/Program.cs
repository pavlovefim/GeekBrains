// Задача 54
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");

        }
        Console.WriteLine("]");
    }
}


void DescendingRow(int[,] matr)
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);

    int temp = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < col - j - 1; k++)
            {
                if(matr[i, k] < matr[i, k + 1])
                {
                    temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 9);
PrintMatrix(matrix);
DescendingRow(matrix);
Console.WriteLine();
PrintMatrix(matrix);
// Задача 56
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");

        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[] FindLeastAvrgRow(int[,] mtrx)
{
    int[] rowSum = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            sumRow += mtrx[i, j];
        }
        rowSum[i] = sumRow;
    }
    return rowSum;
}

int ArrayLeastIndex(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(matrix);
int[] avarage = FindLeastAvrgRow(matrix);
int leastIndex = ArrayLeastIndex(avarage);
Console.WriteLine($"index of the row with the laest avarege -> {leastIndex}");
// Задача 58
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matr = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matr.GetLength(1); j++)
        {

            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],4}, ");
            else Console.Write($"{matr[i, j],4} ");

        }
        Console.WriteLine("]");
    }
    Console.WriteLine();
}

int[,] MultMatrices(int[,] mA, int[,] mB)
{
    int rowA = mA.GetLength(0);
    int colA = mA.GetLength(1);
    int rowB = mB.GetLength(0);
    int colB = mB.GetLength(1);
    int[,] res = new int[rowA, colB];
    //int i,j,k;
    if (colA == rowB)
    {
        for (int i = 0; i < colB; i++)
        {
            for (int j = 0; j < rowA; j++)
            {
                for (int k = 0; k < colA; k++)
                {
                    res[j,i] += mA[j, k] * mB[k, i];
                }
            }
        }
    }
    else
    {
        Console.WriteLine($"{colA} is not equal to {rowB}");
    }
    return res;
}

int[,] matrixA = CreateMatrixRndInt(2, 2, 1, 9);
int[,] matrixB = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(matrixA);
PrintMatrix(matrixB);
int[,] result = MultMatrices(matrixA, matrixB);
PrintMatrix(result);
// Задача 60
int[,,] Create3DArrayRndInt(int x, int y, int z, int min, int max)
{
    int[,,] matr = new int[x, y, z];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                int next = 0;
                while (true)
                {
                    next = rnd.Next(min, max);
                    if (!Contains(matr, next)) break;
                }

                matr[i, j, k] = next;
            }
        }
    }
    return matr;
}

bool Contains(int[,,] matr, int value)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                if (matr[i, j, k] == value) return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.WriteLine($"{matr[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

int[,,] threeDArray = Create3DArrayRndInt(3, 3, 3, 0, 30);
Print3DArray(threeDArray);
// Задача 62
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}