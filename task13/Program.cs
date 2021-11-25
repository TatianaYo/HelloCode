Console.Write("Введите число: ");
int b = Int32.Parse(Console.ReadLine());
int a = new Random().Next(1, 100);

Console.Write("a = ");
Console.WriteLine(a);
if(a % b == 0)
{
   Console.WriteLine("Divisible");
}
else
{
    Console.WriteLine(a % b);
}