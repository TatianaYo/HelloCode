int a = new Random().Next(1, 999999);
Console.Write("a = ");
Console.WriteLine(a);

if(a > 99999) a = a / 1000;
if(a > 9999) a = a / 100;
if(a > 999) a = a / 10;
if(a > 99)
{
    Console.Write("digit3 = ");
    Console.WriteLine(a % 10);
}
else
{
    Console.WriteLine("N/A");
}