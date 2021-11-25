int a = new Random().Next(-40, -1);
Console.Write("a = ");
Console.WriteLine(a);
int b = new Random().Next(1, 40);
Console.Write("b = ");
Console.WriteLine(b);

while(a < b-1)
{
    Console.Write(" ");
    Console.Write(a+1);
    a++;
}