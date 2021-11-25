Console.WriteLine("Введите число: ");
int a = Int32.Parse(Console.ReadLine());

int digit1 = (a % 1000 - a % 100) / 100;
int digit2 = (a % 100 - a % 10) / 10;
int digit3 = a % 10;

Console.Write(digit1);
Console.Write(digit3);