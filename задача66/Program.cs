// Программа вычисляет функцию Аккермана;
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
Console.WriteLine(Accerman(2,2));