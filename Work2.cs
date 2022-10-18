//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine()!);

if (number1 > number2 && number1 > number3)
{
    Console.Write("Первое число больше");
}

else if (number2 > number1 && number2 > number3)
{
    Console.Write("Второе число больше");
}
else if(number3 > number2 && number3 > number1){
    Console.Write("Третье число больше");
}