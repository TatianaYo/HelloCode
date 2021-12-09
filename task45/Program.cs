// Показать числа Фибоначчи
int a = 1;
Console.Write(a + " ");
int b = 0;

for(int i = 0; i < 20; i++)
{
    int result = a + b;
    b = a;
    a = result;
    Console.Write(result + " ");
}
