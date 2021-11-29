Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 || y > 0) 
{
   Console.WriteLine("1 quadrant"); 
}
else
{
    if(x < 0 || y > 0)
    {
    Console.WriteLine("2 quadrant");
    }
    else
    {
        if(x < 0 || y < 0)
        {
            Console.WriteLine("3 quadrant");
        }
        else
        {
            if(x > 0 || y < 0)
            {
                Console.WriteLine("4 quadrant");
            }
        }
    }
}