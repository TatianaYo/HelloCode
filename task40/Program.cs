// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
void FillArray(double[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().NextDouble() + new Random().Next(1, 10000);
        //index = index + 1;
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
double[] array = new double[10];
FillArray(array);
PrintArray(array);
double max = 0;
double min = double.MaxValue;
for(int i = 0; i<array.Length; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
}
double result = max - min;
Console.WriteLine($"{max} - {min} = {result}");