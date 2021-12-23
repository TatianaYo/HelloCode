// Найти сумму элементов от M до N, N и M заданы
int SumNum(int m, int n)
{
    if(m == n) return n;
    else if(m < n) return SumNum(m+1, n) + m;
    else return SumNum(m-1, n) + m;
}
Console.WriteLine(SumNum(3, 1));