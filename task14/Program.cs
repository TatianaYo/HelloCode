int a = new Random().Next(1, 999000);
Console.Write("a = ");
Console.WriteLine(a);

if(a > 99)
{
    Console.Write("digit3 = ");
    Console.Write((a / 100) % 10);
}
else
{
    Console.WriteLine("N/A");
}