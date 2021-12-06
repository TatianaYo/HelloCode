//Определить количество цифр в числе
Console.Write("Введите число: ");
Int64 num = Int64.Parse(Console.ReadLine());
int count = 0;

while(num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine("count = " + count);