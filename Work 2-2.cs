// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

int num = new Random().Next(1, 999);

if (num > 99)
{
    int numberthree = (num % 10);
    Console.WriteLine($"Наше число {num}, а третья цифра числа {numberthree}");
}

else
{
    Console.WriteLine($"Наше число {num} и в нем нет третьей цифры");
}