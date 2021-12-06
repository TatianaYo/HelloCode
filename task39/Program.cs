// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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

int[] array = new int[4];
FillArray(array);
int product = 1;
for(int i = 0; i < array.Length / 2; i++)
{
    product = array[i] * array[array.Length - 1 - i];
    Console.WriteLine($"{array[i]} * {array[array.Length - 1 - i]} = {product}");
}
