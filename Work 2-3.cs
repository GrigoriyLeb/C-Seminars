// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введите номер дня недели ");
int dayOfWeek = int.Parse(Console.ReadLine()!);

if (dayOfWeek > 5)
{
    Console.Write("Это выходной! Наслаждайтесь отдыхом. ");
}
else
{
    Console.Write("Это будний день, идите на работу! ");
}

if (dayOfWeek == 1)
{
    Console.Write("Это понедельник!");
}
else if (dayOfWeek == 2)
{
    Console.Write("Это вторник!");
}
else if (dayOfWeek == 3)
{
    Console.Write("Это среда!");
}
else if (dayOfWeek == 4)
{
    Console.Write("Это четверг!");
}
else if (dayOfWeek == 5)
{
    Console.Write("Это пятница!");
}
else if (dayOfWeek == 6)
{
    Console.Write("Это суббота!");
}
else
{
    Console.Write("Это воскресенье!");
}