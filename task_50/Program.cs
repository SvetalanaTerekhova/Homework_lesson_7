// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

// 1 Вариант, где мы находим значение элемента по заданным индексам строки и столбца

Console.Write("Введите индекс строки элемента двумерного массива, значение которого нужно найти: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца элемента двумерного массива, значение которого нужно найти: ");
int j = int.Parse(Console.ReadLine());
if (i >= array.GetLength (0) || j >= array.GetLength (1))
{
    Console.Write("Ответ: Такого элемента нет в двумерном массиве");
}
else
{
    Console.Write($"Ответ: Элемент в двумерном массиве с индексом строки {i} и индексом столбца {j} -> {array[i,j]}");
}

// 2 Вариант, где мы проверяем есть ли введенное число двумерном массиве

/* Console.Write("Введите число, которое нужно найти в двумерном массиве: ");
int number = int.Parse(Console.ReadLine());
int resul = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == number)
        {
            resul = 1;     
        }
    }
}
if (resul == 1)
{
    Console.WriteLine($"Ответ: {number} - такое число есть в двумерном массиве");
}
else
{
    Console.WriteLine($"Ответ: {number} - такого числа нет в двумерном массиве");
} */