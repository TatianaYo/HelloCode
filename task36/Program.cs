// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[5];
FillArray(array);
PrintArray(array);
int count = 0;
int count1 = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i]%2==0)
    {
        count = count + 1;
    }
    if(array[i]%2!=0)
    {
        count1 = count1 + 1;
    }
}
Console.WriteLine("Четных = " + count);
Console.WriteLine("Нечетных = " + count1);