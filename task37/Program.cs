// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 1000);
        //index = index + 1;
        index++;
    }
}
int[] array = new int[123];
FillArray(array);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]>9 && array[i]<100)
    {
        count = count + 1;
    }
}
Console.WriteLine("Количество элементов из отрезка [10,99] = " + count);