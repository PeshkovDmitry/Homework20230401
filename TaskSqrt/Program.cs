int Sqrt(int n)
{
    for (int i = 0; i <= n; i++) 
        if (i*i <= n && (i + 1)*(i + 1) > n)
            return i;
    return -1;        
} 

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Квадратный корень из {n} равен {Sqrt(n)}");