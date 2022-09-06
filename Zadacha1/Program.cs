Console.Clear();
// int n1 = new Random().Next(0, 1) == 0 ... 0
// int n2 = new Random().Next(10,10 or 11) == 10 ... 10
int a = new Random().Next(0, 1000); 
Console.WriteLine(a);
int b = new Random().Next(0, 1000); 
Console.WriteLine(b);

if (a > b)
{
    int max = a;
    int min = b;
    Console.Write("a=");
    Console.Write(a);
    Console.Write(" больше ");
    Console.Write("b=");
    Console.WriteLine(b);
}
else
{
    if (a == b)
    {
        int max = b;
        int min = a;
        Console.Write("a=");
        Console.Write(a);
        Console.Write(" равен ");
        Console.Write("b=");
        Console.WriteLine(b);
    }
    else
    {
        int max = b;
        int min = a;
        Console.Write("a=");
        Console.Write(a);
        Console.Write(" меньше ");
        Console.Write("b=");
        Console.WriteLine(b);
    }
};