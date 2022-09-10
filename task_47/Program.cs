// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// 1 Вариант, когда диапазон генерации случайных чисел задан с помощью NextDouble

double[,] FillArray(int row, int column, int min, int max)
{
    double[,] fill = new double[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            fill[i, j] = Math.Round(new Random().NextDouble() * (max - min + 1) + min, 2);
        }
    }
    return fill;
}

// 2 Вариант, когда диапазон генерации случайных чисел задан с помощью суммирования случайно заданной целой частью и случайно заданной дробной частью числа

/* double[,] FillArray(int row, int column, int min, int max)
{
    double[,] fill = new double[row, column];
    double number1 = 0;
    double number2 = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Random random = new Random();
            number1 = random.Next(min, max);
            number2 = random.Next(min, max);
            number2 = number2 / 100;
            fill[i, j] = number1 + number2;
        }
    }
    return fill;
} */

void PrintArray(double[,] print)
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

double[,] array = FillArray(row, column, MinMeaning, MaxMeaning);
Console.WriteLine("Ответ: Двумерный массив, заполненный случайными вещественными числами: ");
PrintArray(array);