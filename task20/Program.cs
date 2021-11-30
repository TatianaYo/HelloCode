//Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти: ");
int quadrant = int.Parse(Console.ReadLine());

if(quadrant == 1)
{
    Console.WriteLine("По оси X от 1 до бесконечности");
    Console.WriteLine("По оси Y от 1 до бесконечности");
}
if(quadrant == 2)
{
    Console.WriteLine("По оси X от -1 до -бесконечности");
    Console.WriteLine("По оси Y от 1 до бесконечности");
}
if(quadrant == 3)
{
    Console.WriteLine("По оси X от -1 до -бесконечности");
    Console.WriteLine("По оси Y от -1 до -бесконечности");
}
if(quadrant == 4)
{
    Console.WriteLine("По оси X от 1 до бесконечности");
    Console.WriteLine("По оси Y от -1 до -бесконечности");
}