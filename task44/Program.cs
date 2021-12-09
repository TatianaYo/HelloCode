//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
//b1 k1 и b2 и k2 заданы
Console.WriteLine("Please enter number k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number b2: ");
int b2 = int.Parse(Console.ReadLine());

double X = (b2-b1)/(k1-k2);
double Y = k1 * X + b1;
Console.WriteLine("X = " + X);
Console.WriteLine("Y = " + Y);