// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
int NewCount = 2;
while (NewCount <= A)
{
Console.Write($"{NewCount}" );
NewCount += 2;
}


