//Выяснить являются ли три числа сторонами треугольника 
Console.WriteLine("Please enter number A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number C: ");
int C = int.Parse(Console.ReadLine());

if(A+B>C && A+C>B && B+C>A) Console.WriteLine("Yes");
else
{
    Console.WriteLine("NO!");
}
