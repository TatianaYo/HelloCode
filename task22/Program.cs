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
//Console.Write("AB = " + AB);


//Найти расстояние между точками в пространстве 3D
//Console.Write("Введите координату xA: ");
//int xA = int.Parse(Console.ReadLine());
//Console.Write("Введите координату yA: ");
//int yA = int.Parse(Console.ReadLine());
//Console.Write("Введите координату zA: ");
//int zA = int.Parse(Console.ReadLine());
//Console.Write("Введите координату xB: ");
//int xB = int.Parse(Console.ReadLine());
//Console.Write("Введите координату yB: ");
//int yB = int.Parse(Console.ReadLine());
//Console.Write("Введите координату zB: ");
//int zB = int.Parse(Console.ReadLine());

//double AB = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + Math.Pow(zB-zA, 2));
//Console.Write("AB = " + AB);

//Найти расстояние между точками в пространстве 2D/3D
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

double x = xB - xA;
double y = yB - yA;
double z = zB - zA;

double dis2D = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
double dis3D = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));

Console.WriteLine("Растояние для 2D  пространства: " + dis2D);
Console.WriteLine("Растояние для 3D  пространства: " + dis3D);