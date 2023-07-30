// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[] GetData(string text) // Функция запрашивает у пользователя информацию и записывает в целочисленный массив
{
    Console.Write($"{text} ");
    string[] input = Console.ReadLine()!.Split(new char[] {' ', ','});
    int[] numbers = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
        numbers[i] = Convert.ToInt32(input[i]);

    return numbers;
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

int[,] FillArray(int[] linesAndColumns) //Функция заполняет массив случайными целыми числами от 0 до 99
{
    int[,] array = new int[linesAndColumns[0], linesAndColumns[1]];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0, 100);

    return array;
}

void FindElement(int[,] array, int[] position) //Функция находит и выводит на экран элемент по его координатам 
{
    position[0] = position[0] - 1;
    position[1] = position[1] - 1;

    if (position.Length > 2 || position[0] >= array.GetLength(0) || position[1] >= array.GetLength(1))
        Console.WriteLine("Такого элемента массива не существует");
    else
        Console.WriteLine($"Искомый элемент: {array[position[0], position[1]]}");
}

int[,] mainArray = FillArray(GetData("Введите количество строк и столбцов через запятую или пробел: "));
PrintArray(mainArray);
FindElement(mainArray, GetData("Введите позицию нужно элемента(строка/столбец) через запятую или пробел: "));