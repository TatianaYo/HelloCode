//Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());
int result = 1;

for(int i = 0; i < B; i++)
{
    result = result * A;
}
Console.WriteLine($"{A} в степени {B} = " + result);