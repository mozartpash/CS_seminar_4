// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[] Fill(int [] num)//заполняем массив длинной, которую укажет пользак
{
    for (int i = 0; i < num.Length; i++)//счётчик по длинне массива
    {
        num[i] = new Random().Next(0, 2);    // Заполняем массив нулями и единицами. Ставим до двух, потому что справа он вычитает 1.
        Console.Write(num[i] + " ");
    }
    return num;
}

void PrintMass(int [] num)//функция для печати массива
{
    {
    for (int i = 0; i < num.Length; i++)//счётчик по длинне массива
    {
        Console.Write(num[i] + " ");
    }    
}
}
int N = Promt("Введите длинну массива: ");
int[] array = new int[N];//Объявляем пустой массив длинной N, указанной пользаком
PrintMass(Fill(array));