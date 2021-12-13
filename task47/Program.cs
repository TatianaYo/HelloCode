// Написать программу копирования массива
int[] array = {1,2,8,7,4};

int[] arrayCopy = new int[5];

for (int i = 0; i < array.Length; i++)
{
        arrayCopy[i] = array[i];
        Console.Write(" " + arrayCopy[i]);
}