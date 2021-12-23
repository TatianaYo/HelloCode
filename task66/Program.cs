//Показать натуральные числа от 1 до N, N задано
void PrintNum(int start, int end)
{
    Console.WriteLine(start);
    if(start < end) PrintNum(start+1, end);
}
int a = 1;
int n = 10;
PrintNum(a, n);
//PrintNum(1, 70);