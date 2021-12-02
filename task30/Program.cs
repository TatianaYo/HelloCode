//Показать кубы чисел, заканчивающихся на четную цифру
int n = 10;


for(int i = 1; i <= n; i++)
{
    if((Math.Pow(i, 3)) % 2 == 0) Console.WriteLine(Math.Pow(i, 3));
}