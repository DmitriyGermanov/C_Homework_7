// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetNumber(string text) // Функция запрашивает у пользователя число
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine()!);
}

int[,] FillArray(int lines, int columns) //Функция заполняет массив случайными целыми числами от 0 до 99
{
    int[,] array = new int[lines, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0, 100);

    return array;
}

void PrintArray(int[,] array) //Функция печатает массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] array)  //Функция находит среднее арифметическое строки двумерного массива
{
    double averageValue = 0;
    string result = "Средние арифметические строк = ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            averageValue += array[i, j];

        averageValue /= array.GetLength(1);
        if (i == 0)
            result += Math.Round(averageValue,2).ToString();
        else
            result += "; " + Math.Round(averageValue,2).ToString();

        averageValue = 0;
    }
    Console.WriteLine(result);
}

int[,] mainArray = FillArray(GetNumber("Введите количество строк массива: "),
                                GetNumber("Введите количество столбцов массива:"));
PrintArray(mainArray);
Console.WriteLine();
ArithmeticMean(mainArray);