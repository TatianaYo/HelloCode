int a = 1;
int b = new Random().Next(2, 100);
Console.Write("b = ");
Console.WriteLine(b);

while(a < b)
{
    if(a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}