//Найти расстояние между точками в пространстве 2D
//Console.Write("Введите координату xA: ");
//int xA = int.Parse(Console.ReadLine());
//Console.Write("Введите координату yA: ");
//int yA = int.Parse(Console.ReadLine());
//Console.Write("Введите координату xB: ");
//int xB = int.Parse(Console.ReadLine());
//Console.Write("Введите координату yB: ");
//int yB = int.Parse(Console.ReadLine());

//double AB = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2));
//Console.Write("AB = ");
//Console.WriteLine(AB);


//Найти расстояние между точками в пространстве 3D
Console.Write("Введите координату xA: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите координату yA: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите координату zA: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите координату xB: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите координату yB: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите координату zB: ");
int zB = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
Console.Write("AB = ");
Console.WriteLine(AB);