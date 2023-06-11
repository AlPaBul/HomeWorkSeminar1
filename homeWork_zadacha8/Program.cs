// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Clear();

Console.Write("Введите любое целое число: ");
int num1 = int.Parse(Console.ReadLine());

int count = 0;
int znach;
while (count < num1){

    count++;
    Console.WriteLine($"count = {count}");
    
    znach = count%2;

    if (znach==0){
        Console.WriteLine($"четное числа {count}");
    }
}


