// Программа выведет все натуральные числа в промежутке от N до M
int Foo (int N, int M)
{
    if (N < M)
    {
        return M;
    }
    Console.Write("{0}", M + " ");
    M++;
    return Foo (N, M);
}
Foo(20, 10);