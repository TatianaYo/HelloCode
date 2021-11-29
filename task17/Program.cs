Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());

if(numberB*numberB == numberA)
{
    Console.WriteLine("numberA является квадратом numberB");
}
else
{
    Console.WriteLine("numberA не является квадратом numberB");
}
if(numberA*numberA == numberB)
{
    Console.WriteLine("numberB является квадратом numberA");
}
else
{
    Console.WriteLine("numberB не является квадратом numberA");
}