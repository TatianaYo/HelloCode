// Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)" и отдельно задавался коэффициент масштабирования - 2
// или 4 или 0.5 и просто показать координаты, которые получатся.
//при двойке - "(0,0) (4,0) (4,4) (0,4)"
int k = 2;
int[] A = {0,0}, B = {2,0}, C = {2,2}, D = {0,2};

for(int i = 0; i < 2; i++)
{
     int[] A1 = new int[2];
     A1[i]= A[i] * k;
     Console.Write(" " + A1[i]);
}
Console.WriteLine();
for(int i = 0; i < 2; i++)
{
     int[] B1 = new int[2];
     B1[i]= B[i] * k;
     Console.Write(" " + B1[i]);
}
Console.WriteLine();
for(int i = 0; i < 2; i++)
{
     int[] C1 = new int[2];
     C1[i]= C[i] * k;
     Console.Write(" " + C1[i]);
}
Console.WriteLine();
for(int i = 0; i < 2; i++)
{
     int[] D1 = new int[2];
     D1[i]= D[i] * k;
     Console.Write(" " + D1[i]);
}
