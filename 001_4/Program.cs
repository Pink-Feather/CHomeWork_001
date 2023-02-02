// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 1;

if (number < 1)
{
   Console.WriteLine($"Последовательность четных чисел вывести невозможно по условию задачи");
}
else
{
 Console.Write("Последовательность четных числе: "); 
 while (count <= number)
  {
     if (count % 2 == 0)
    {
      Console.Write($"{count}, ");
    }
  count = count + 1;
  }
}     