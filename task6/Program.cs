int a = new Random().Next(1, 40); // 1 2 3 4 ... 39
Console.Write("a = ");
Console.WriteLine(a);

if(a % 2 == 0)
{
    Console.WriteLine("even integer");
}
else
{
    Console.WriteLine("uneven integer");
}