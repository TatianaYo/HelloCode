//Программа проверяет пятизначное число на палиндромом.
int a = new Random().Next(10000, 99999);
Console.Write("a = ");
Console.WriteLine(a);


int a1 = a % 10;
int a2 = (a % 100 - a % 10) / 10;
int a3 = (a % 1000 - a % 100) / 100;
int a4 = (a % 10000 - a % 1000) / 1000;
int a5 = a / 10000;

if(a1==a5 && a2==a4) Console.WriteLine("Palindrome");
else
{
    Console.WriteLine("Not a palindrome");
}





//Проверяет любое число на палиндром

//Console.Write("Enter a number: ");
//string a = Console.ReadLine();
//char[] A = a.ToCharArray();

//Array.Reverse(A);
//string finalA = new string(A);

//if(a == finalA)
//{
//    Console.WriteLine("Palindrome");
//}
//else
//{
//    Console.WriteLine("Not a palindrome");
//}
