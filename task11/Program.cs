int a = new Random().Next(10, 99);
Console.WriteLine(a);

int digit1 = a / 10;
Console.WriteLine(digit1);
int digit2 = a % 10;
Console.WriteLine(digit2);

if (digit1 < digit2)
{
    Console.Write("max = ");
    Console.WriteLine(digit2);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(digit1);
}