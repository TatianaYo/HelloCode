// Написать программу копирования массива
int[] array = {1,2,8,4,4};

int[] arrayCopy = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
        arrayCopy[i] = array[i];
        Console.WriteLine(array[i] + " - " + arrayCopy[i]);
}
// array[3] = 7;
// Console.WriteLine();
// for(int i = 0; i < array.Length; i++)
// {
//         Console.WriteLine(array[i] + " - " + arrayCopy[i]);
// }