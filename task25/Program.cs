//Найти сумму чисел от 1 до А
int x = 1;
int a = 3;
int sum = 1;

while(x < a)
{
    sum = sum + (x + 1);
    x++;
}
Console.WriteLine("Сумма = " + sum);