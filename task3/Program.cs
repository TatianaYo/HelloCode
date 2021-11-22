int daynumber = new Random().Next(1, 8); //1 2 3 ... 7
Console.WriteLine(daynumber);

if(daynumber == 1)
{
    Console.WriteLine("M");
}
if(daynumber == 2)
{
    Console.WriteLine("T");
}
if(daynumber == 3)
{
    Console.WriteLine("W");
}
if(daynumber == 4)
{
    Console.WriteLine("Th");
}
if(daynumber == 5)
{
    Console.WriteLine("F");
}
if(daynumber == 6)
{
    Console.WriteLine("S");
}
if(daynumber == 7)
{
    Console.WriteLine("Sun");
}
