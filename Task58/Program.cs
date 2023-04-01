// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ReleaseMatrix(int[,] a, int[,] b)
{
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    if (a.GetLength(1) == b.GetLength(0))
    {
        for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                int sum = 0;
                for (int r = 0; r < a.GetLength(1); r++)
                {
                    sum += a[i,r] * b[r, j];
                }
                c[i,j] = sum;
            }
        }
    }
    else
    {
        Console.WriteLine("Умножение матриц заданного размера невозможно");
        return null;
    }
    return c;
}

Console.Clear();
Console.WriteLine("Генерируем матрицу 1");
int[,] matrix1 = InputMatrix();
// int[,] matrix1 = {{2,4},{3,2}};
PrintMatrix(matrix1);
Console.WriteLine("Генерируем матрицу 2");
int[,] matrix2 = InputMatrix();
// int[,] matrix2 = {{3,4},{3,3}};
PrintMatrix(matrix2);
int[,] result = ReleaseMatrix(matrix1, matrix2);
if (result != null) PrintMatrix(result);