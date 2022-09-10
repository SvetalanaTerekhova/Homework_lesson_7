//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] fill = new int[row, column];
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = new Random().Next(min, max);
        }
    }
    return fill;
}

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение диапазона генерации случайных чисел: ");
int MinMeaning = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона генерации случайных чисел: ");
int MaxMeaning = int.Parse(Console.ReadLine());

while (MinMeaning > MaxMeaning)
{
    Console.Write("Вы ввели минимальное значение диапазона генерации случайных чисел больше чем максимальное. ");
    Console.WriteLine("Сформировать такой диапазон генерации случайных чисел невозможно.");
    Console.Write("Введите минимальное значение диапазона генерации случайных чисел меньше чем максимальное: ");
    MinMeaning = int.Parse(Console.ReadLine());
    Console.Write("Введите максимальное значение диапазона генерации случайных чисел: ");
    MaxMeaning = int.Parse(Console.ReadLine());
}

int[,] array = FillArray(row, column, MinMeaning, MaxMeaning);
Console.WriteLine("Двумерный массив, заполненный случайными числами: ");
PrintArray(array);
Console.Write("Ответ: среднее арифмитическое каждого столбца: ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    double ArithmeticalMean = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];        
    }
    ArithmeticalMean = Math.Round(sum / array.GetLength(0), 2);
    Console.Write($"{ArithmeticalMean}; ");
}