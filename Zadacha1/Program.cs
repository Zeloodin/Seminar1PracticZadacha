Console.Clear();

int a = new Random().Next(0, 1000); // int (0, 1) == 0 ... 0
Console.WriteLine(a);
int b = new Random().Next(0, 1000); // int (10,10 or 11) == 10 ... 10
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