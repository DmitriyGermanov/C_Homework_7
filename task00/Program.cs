// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using System.Data;
using System.Security.Cryptography;

int GetNumber(string text) // Функция запрашивает у пользователя число
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine()!);
}

double[,] FillArray(int line, int columns) //Функция заполняет массив случайными вещественными числами с округлением до двух знаков после запятой
{
    double[,] array = new double[line, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(random.Next(-100, 100) + random.NextDouble(), 2);

    return array;
}

void PrintArray(double[,] array) //Функция печатает массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
}

double[,] mainArray = FillArray(GetNumber("Введите количество строк:"),
                                GetNumber("Введите количество столбцов:"));
PrintArray(mainArray);