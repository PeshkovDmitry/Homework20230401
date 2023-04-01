// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSubMatrix(int[,] m, int offset)
{
    // Обходим периметр с учетом смещения
    // Заполняем строку сверху
    for (int i = offset + 1; i < m.GetLength(1) - offset; i++) 
        m[offset,i] = m[offset,i - 1] + 1;
    // Заполняем строку справа
    for (int i = offset + 1; i < m.GetLength(0) - offset; i++) 
        m[i, m.GetLength(1) - offset - 1] = m[i - 1, m.GetLength(1) - offset - 1] + 1;
    // Заполняем строку снизу
    for (int i = m.GetLength(1) - offset - 2; i >= offset ; i--) 
        m[m.GetLength(0) - offset - 1,i] = m[m.GetLength(0) - offset - 1, i + 1] + 1;
    // Заполняем строку слева
    for (int i = m.GetLength(0) - offset - 2; i > offset; i--) 
        m[i, offset] = m[i + 1, offset] + 1;
    // Обход периметра закончен, если внутри него есть незаполненные ячейки,
    // рекурсивно вызываем эту же функцию
    if (m[offset + 1, offset + 1] == 0) 
    {
        m[offset + 1, offset + 1] = m[offset + 1, offset] + 1;
        FillSubMatrix(m, offset + 1);
    }
}


int[,] CreateMatrix()
{
    Console.Write("Введите размер стороны матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[0]];
    matrix[0,0] = 1;
    FillSubMatrix(matrix, 0);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:d2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int[,] matrix = CreateMatrix();
PrintMatrix(matrix);