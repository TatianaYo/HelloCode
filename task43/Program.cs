//Написать программу преобразования десятичного числа в двоичное
Console.Write("Decimal: ");
int decimalNumber = int.Parse(Console.ReadLine());

string result = string.Empty;
while (decimalNumber > 0)
{
     int remainder = decimalNumber % 2;
     decimalNumber /= 2;
     result = remainder.ToString() + result;
}
Console.WriteLine("Binary: {0}", result);