//Подсчитать сумму цифр в числе
Console.Write("Enter a number: ");
int A = int.Parse(Console.ReadLine());
int result = 0;

while(A > 0)
{
    result = result + (A % 10);
    A = A / 10;
}
Console.WriteLine(result);