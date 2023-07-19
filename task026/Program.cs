// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}


int Result(int num)
{
int count = 0;
for (; num > 0; count++)//Первое условие: count = 0 можно не писать так как он и так 0
{
    num = num / 10;
}
return count;
}
int num = Promt("Введите число: ");
Console.WriteLine($"Количество цифр в вашем числе: {Result(num)}");

