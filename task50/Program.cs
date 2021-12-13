// В двумерном массиве n×k заменить четные элементы на противоположные
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// [1; 10)
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

int[,] array = new int[3,3];
FillArray(array);
PrintArray(array);
Console.WriteLine();
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] % 2 == 0) array[i,j] = array[i,j] * (-1);
        }
}
PrintArray(array);