// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите первое число: ");
int numberA = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите второе число: ");
int numberB = int.Parse (Console.ReadLine()!);
Console.WriteLine ("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine()!);

int max = numberA;

if (max > numberB)
    if (max > numberC)
    {
    Console.WriteLine($"Максимальное число {max }");
    }
    else 
       if (numberC > numberB)
       {
       Console.WriteLine($"Максимальное число {numberC}");
       }
       else
       {
       Console.WriteLine($"Максимальное число {numberB}");
       }
else 
    if (numberB > numberC)
    {
    Console.WriteLine($"Максимальное число {numberB}");
    }
    else
    {
    Console.WriteLine($"Максимальное число {numberC}");
    }
