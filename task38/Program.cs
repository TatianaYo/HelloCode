// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
int[] array = new int[10];
FillArray(array);
int sum = 0;
for(int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);