int daynum = new Random().Next(1, 8);
Console.Write("daynum = ");
Console.WriteLine(daynum);

if(daynum < 6)
{
    Console.WriteLine("Workday");
}
else
{
    Console.WriteLine("Weekend");
}