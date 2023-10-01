﻿﻿//------------------------------------------------------------------------------------------------------------------
//                                                   Задача 47
//                                          Домашнее задание к семинару 07                                        
//   Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//   * При выводе матрицы показывать каждую цифру разного цвета. Вывод числа ограничить до 2 знака после запятой.
//------------------------------------------------------------------------------------------------------------------

//                                                 Тело программы
//------------------------------------------------------------------------------------------------------------------
Console.Clear();
// Ввод парметров матрицы.
int countRow = ReadInt("Введите количество строк m: ");
int countColumn = ReadInt("Введите количество cтолбцов n: ");

// Генерация и вывод матрицы.
int minValue = -10;
int maxValue = 10;
double[,] matrix = CreateRandomMatrix(countRow, countColumn, minValue, maxValue);
PrintMatrix(matrix);

//                                                     Методы
//------------------------------------------------------------------------------------------------------------------

// Ввод целого числа с клавиатуры.
int ReadInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Генераци двумерного массива, заполненного случайными вещественными значениями.
double[,] CreateRandomMatrix(int countRow, int countColumn, int minValue, int maxValue)
{
    Random random = new Random();
    double[,] matrix = new double[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            matrix[i, j] = (maxValue - minValue) * random.NextDouble() + minValue;
        }
    }
    return matrix;
}
// Вывод двумерного массива на экран.
void PrintMatrix(double[,] matrix)
{
    int countRow = matrix.GetLength(0);
    int countColumn = matrix.GetLength(1);

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            string formattedNumber = matrix[i, j].ToString("0.00");
            DisplayColoredText(formattedNumber);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}

// Вывод каждого символа случайным цветом.
void DisplayColoredText(string text)
{
    foreach (char c in text)
    {
        ConsoleColor randomColor;

        // Символы, отличные от цифр оставляем белыми.
        if (Char.IsDigit(c)) { randomColor = GetRandomConsoleColor(); }
        else { randomColor = ConsoleColor.White; }

        Console.ForegroundColor = randomColor;
        Console.Write(c);
        Console.ResetColor();
    }
}

// Получение случайного цвета для текста.
ConsoleColor GetRandomConsoleColor()
{
    Random random = new Random();
    ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
    return colors[new Random().Next(colors.Length)];
}

// double[,] RandomArray(int m, int n, int min, int max)
// {
//     System.Random rnd = new System.Random();
//     double[,] array2D = new double[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array2D[i,j] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(),1);
//         }
//     }

//     return array2D;
// }
// void Print2DArray(double[,] matrix)
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i,j]+"\t");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] array2D = RandomArray(5, 6, -10, 10);
// Print2DArray(array2D);