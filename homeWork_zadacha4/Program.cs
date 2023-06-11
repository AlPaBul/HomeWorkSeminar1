// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write ("введите любое целое число num1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write ("введите любое целое число num2: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write ("введите любое целое число num3: ");
int num3 = int.Parse(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.WriteLine($"Болешим из чисел {num1}, {num2}, {num3} является число: {max}");
