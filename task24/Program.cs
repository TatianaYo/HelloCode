//Найти кубы чисел от 1 до N
int a = 1;
int n = 20;

while(a <= n)
{
    double cube = Math.Pow(a, 3);
    Console.WriteLine($"{a} * {a} * {a} = " + cube);
    a++;
}