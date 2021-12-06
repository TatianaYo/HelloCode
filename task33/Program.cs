// Задать массив из 12 элементов, 
//заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = {1,1,1,1,1,1,1,1,1,1,1,1};
int sum = 0;
for(int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for(int i=0; i<array.Length; i++)
{
    sum = sum + array[i];
}
Console.WriteLine("sum = " + sum);