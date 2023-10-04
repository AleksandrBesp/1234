// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}


int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    int[,] arr2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr2D[i, j] = new Random().Next(downBorder, topBorder + 1);
        }
    }
    return arr2D;
}

void Print2DArray(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {

            Console.Write(arr2D[i,j]+"\t");
        }
        Console.WriteLine();
    }
}
//Размещение элементов массива по порядку возростания в строке.
void RowNumOrder (int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            for (int k = 0; k < arr2D.GetLength(1) - 1; k++)
            {
                if (arr2D[i, k] < arr2D[i, k + 1])
                {
                    int temp = arr2D[i, k + 1];
                    arr2D[i, k + 1] = arr2D[i, k];
                    arr2D[i, k] = temp;
                }
            }
        }
    }
} 
    
Console.Clear();
int countRow = ReadData("Количество строк: ");
int countColumn = ReadData("Количество столбцов: ");
Console.WriteLine("Исходная матрица");
int[,] arr2D = Fill2DArray(countRow,countColumn,10,1);
Print2DArray(arr2D);
Console.WriteLine("________________");
RowNumOrder(arr2D);
Print2DArray(arr2D);