//Написать программу вычисления произведения чисел от 1 до N
int N = 4;
int res = 1;

for(int x = 1; x <= N; x++)
{
    res = res * x;
}
Console.WriteLine(res);