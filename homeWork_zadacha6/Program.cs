// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите любое целое число: ");
int num1 = int.Parse(Console.ReadLine());

int znach = num1%2;

if (znach==0){
    Console.WriteLine($"ваше число {num1} четное");
}
else Console.WriteLine($"выше число {num1} не является четным");

