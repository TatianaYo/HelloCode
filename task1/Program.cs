int numberA = new Random().Next(1, 100); // 1 2 3 4 ... 99
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);

if(numberB*numberB == numberA)
{
    Console.WriteLine("NumberA является квадратом numberB");
}

else
{
    Console.WriteLine("NumberA не является квадратом numberB");
}
