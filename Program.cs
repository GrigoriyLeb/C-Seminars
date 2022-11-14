// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

void Formula(int red)
{
    int one = red / 10000;
    int two = red % 10;
    int three = red / 1000 % 100;
    int four = red % 100 / 10;
    if (red < 10000)
    {
        Console.WriteLine("Вы ввели не верное число!");
    }
    else if (red > 99999)
    {
        Console.WriteLine("Вы ввели не верное число");
    }
    else if (one == two && three == four)
    {
        Console.WriteLine("Это полиндром");
    }
    else
    {
        Console.WriteLine("Это не полиндром");
    }
}
Console.WriteLine("Введите пятизначное число");
int red = int.Parse(Console.ReadLine()!);
Formula(red);