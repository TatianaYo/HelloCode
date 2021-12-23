//Найти сумму цифр числа
void Sum(string a)
{
    char[] A = a.ToCharArray();
    for(int i = 0; i < A.Length; i++)
    {
        return Sum(A[i]) + A[i];
    }
}
Console.WriteLine(Sum(123));