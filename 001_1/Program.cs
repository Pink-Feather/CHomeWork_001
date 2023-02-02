// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!); 
Console.WriteLine ("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

int max = numberA;

if (max > numberB)
{
    Console.WriteLine($"Максимальное число {numberA}, минимальное число {numberB}");
}
else 
Console.WriteLine($"Максимальное число {numberB}, минимальное число {numberA}");

