// Программа найдет сумму натуральных элементов от М до N
Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine());

void Sum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
Sum(M, N, sum);
}

Sum(M, N, 0);