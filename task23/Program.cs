//Показать таблицу квадратов чисел от 1 до N 
int a = 1;
int n = 20;

while(a <= n)
{
    double Sqrt = Math.Pow(a, 2);
    Console.WriteLine($"{a} * {a} = " + Sqrt);
    a++;
}