Console.Clear();
// int n1 = new Random().Next(0, 1) == 0 ... 0
// int n2 = new Random().Next(10,10 or 11) == 10 ... 10
int a = new Random().Next(0, 1000); 
int b = new Random().Next(0, 1000); 
Console.Write("a=");
Console.Write(a);
if (a > b)
{
    int max = a;
    int min = b;
    Console.Write(" больше ");
}
else if (a == b)
{
    int max = b;
    int min = a;
    Console.Write(" равен ");
}
else
{
    int max = a;
    int min = b;
    Console.Write(" меньше ");
};
Console.Write("b=");
Console.WriteLine(b);