﻿int numberA;
int numberB;
int numberC;

Console.Write("Введите целое первое число: ");
while (!int.TryParse(Console.ReadLine(), out numberA))
{
    Console.Write("Ошибка ввода! Введите целое первое число: ");
}

Console.Write("Введите целое второе число: ");
while (!int.TryParse(Console.ReadLine(), out numberB))
{
    Console.Write("Ошибка ввода! Введите целое второе число: ");
}

Console.Write("Введите целое третье число: ");
while (!int.TryParse(Console.ReadLine(), out numberC))
{
    Console.Write("Ошибка ввода! Введите целое третье число: ");
}
int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.Write("Введённое максимальное число: max = ");
Console.WriteLine(max);

Console.WriteLine($"{numberA}, {numberB}, {numberC} -> {max}");
