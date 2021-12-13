// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 15);// [1; 10)
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5,6];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 1; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1); j++)
    {
        if(i % 2 == 0 && j % 2 == 0) array[i,j] = array[i,j] * array[i,j];
    }
}
PrintArray(array);