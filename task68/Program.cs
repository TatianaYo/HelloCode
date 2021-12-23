// Показать натуральные числа от M до N, N и M заданы
void PrintNum(int start, int end)
{
    Console.WriteLine(start);
    if(start < end) PrintNum(start+1, end);
}
int m = 1;
int n = 10;
PrintNum(a, n);
//PrintNum(1, 70);
