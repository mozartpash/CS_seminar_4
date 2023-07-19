// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Result(int num)
{
    int result = 1;//потому что счётчик от 1
    for (int i = 1; i <= num; i++)// i=1 потому что счётчик от 1
    {
        result = result * i;// Перезаписываем result и умножаем на счётчик        
    }
    Console.WriteLine($"произведение чисел от 1 до {num} = {result}");
}

int number = Promt("Введите число: ");
Result(number);
