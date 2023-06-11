// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write ("введите любое целое число num1: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write ("введите любое целое число num2: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;

Console.WriteLine($"Болешее из числа {num1} и {num2} является число {max}");




