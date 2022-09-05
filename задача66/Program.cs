// Программа вычисляет функцию Аккермана;
Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int N = int.Parse(Console.ReadLine());

int Accerman(int N, int M)
{
    if (N == 0)
        return M + 1;
    else
    if ((N != 0) && (M == 0))
        return Accerman(N - 1, 1);
    else
        return Accerman(N - 1, Accerman(N, M - 1));
}
Console.WriteLine(Accerman(N,M));