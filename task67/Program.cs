// Показать натуральные числа от N до 1, N задано
void PrintNum(int start, int end)
{
    if(start < end) PrintNum(start+1, end);
    Console.WriteLine(start);
}
int a = 1;
int n = 10;
PrintNum(a, n);
//PrintNum(1, 70);