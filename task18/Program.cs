bool X = false;
bool Y = true;

bool F1 = !(X|Y);
Console.Write("F1 = ");
Console.WriteLine(F1);
bool F2 = !X&!Y;
Console.Write("F2 = ");
Console.WriteLine(F2);

if(F1==F2)
{
    Console.WriteLine("The expression is true");
}
else
{
    Console.WriteLine("The expression is false");
}
