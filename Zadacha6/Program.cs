Console.Write("Введите число: ");
int number2 = Convert.ToInt(Console.ReadLine());
if (number2 % 2 == 0)
{
    Console.WriteLine($"число {number2} чётное");  
}
else
{
    Console.WriteLine($"число {number2} нечётное");  
};
