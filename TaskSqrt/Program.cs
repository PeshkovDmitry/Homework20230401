int Sqrt(int n, ref int count)
{
    count = 0;
    for (int i = 0; i <= n; i++)
    {
        count++;
        if (i * i <= n && (i + 1) * (i + 1) > n) return i;
    }
    return -1;
}

void SqrtPro(int n, int start, int end, ref int count)
{
    if (end > start + 1)
    {
        count++;
        int i = start + (end - start) / 2;
        if (i * i > n) SqrtPro(n, start, i, ref count);
        else if ((i + 1) * (i + 1) < n) SqrtPro(n, i, end, ref count);
        else Console.WriteLine($"Квадратный корень из {n} равен {i}, число итераций (рекурсия) {count}");
    } 
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine($"Квадратный корень из {n} равен {Sqrt(n, ref count)}, число итераций (цикл) {count}");
count = 0;
SqrtPro(n, 0, n, ref count);