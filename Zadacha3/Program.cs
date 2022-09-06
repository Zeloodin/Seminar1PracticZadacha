Console.Write("Введите число: ");
double number2 = Convert.ToDouble(Console.ReadLine());
if (number2 % 2 == 0)
{
    Console.WriteLine($"число {number2} чётное");  
}
else
{
    Console.WriteLine($"число {number2} нечётное");  
};