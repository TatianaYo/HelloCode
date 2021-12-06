bool X = false;
bool Y = true;

bool F1 = !(X|Y);
Console.WriteLine("F1 = " + F1);
bool F2 = !X&!Y;
Console.WriteLine("F2 = " + F2);

if(F1==F2)
{
    Console.WriteLine("The expression is true");
}
else
{
    Console.WriteLine("The expression is false");
}
