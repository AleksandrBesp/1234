// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк  массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] random2DArray = new int[row,col];

void Fill2DArray(int row, int col)
{
int i,j;
Random rand = new Random();
for (i = 0; i < row; i++)
{
for (j = 0; j < col; j++)
{
random2DArray[i,j] = rand.Next(1,10);
}
}
}

void print2DArray(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]}"+"\t");
}
Console.WriteLine();
}
}

Fill2DArray(row,col);
Console.WriteLine("Исходный массив: ");
print2DArray(random2DArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
    sum += array[i,j];
    }
return sum;
}

int minSum = 1;
int sum = SumLine(random2DArray, 0);
for (int i = 1; i < random2DArray.GetLength(0); i++)
{
    if (sum > SumLine(random2DArray, i))
    {
    sum = SumLine(random2DArray, i);
    minSum = i+1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");