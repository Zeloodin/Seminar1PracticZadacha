Console.Write("Введите число: ");
double numberN = Convert.ToDouble(Console.ReadLine());
for (int i = 1; i <= numberN; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    };
}
Console.WriteLine();