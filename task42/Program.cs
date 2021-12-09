//Определить сколько чисел больше 0 введено с клавиатуры
int k = 10;
int count = 0;
for(int i = 0; i < k; i++)
{
    Console.WriteLine("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    if(n > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine("Количество чисел больше 0 = " + count);



// int a = 12040;
// string str = a.ToString();
// // int[] b = new int[str.Length];
// for( int i=0; i< str.Length; i++)
// {
//      b[i] = int.Parse(str[i].ToString());
// }
// int L = 0;
// for(int i = 0; i < b.Length; i++)
// {
//     if(b[i] >= 1) L = L + 1;
// }
// Console.WriteLine("L = " + L);