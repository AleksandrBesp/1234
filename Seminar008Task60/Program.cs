// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

void Fill3DArray(int countRow, int countColumn, int countFloor)//задаёт размер массива
{
    int[,,] array3d = new int[countRow, countColumn, countFloor];
 
    FillRandom(array3d, new Random());
    WriteArray3d(array3d);
}
       
 
void FillRandom(int[,,] array3d, Random random)//задаёт в массив рандомные числа
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for(int t = 0; t < array3d.GetLength(2); t++)
            {
                int randNumber = random.Next(10, 99);
 
                while (Array3dContains(array3d, randNumber))
                {
                    randNumber = random.Next(10, 99);
                }
 
             array3d[i, j, t] = randNumber;
 
            }
        }
    }
}
 
bool Array3dContains(int[,,] array3d, int randNumber)//Проверяет повторы чисел
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for(int t = 0; t < array3d.GetLength(2); t++)
            {
                if (array3d[i, j, t] == randNumber)
                return true;
             }
        }
    }
    return false;
}
 
void WriteArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for(int t = 0; t < array3d.GetLength(2); t++)
            {
            Console.Write(array3d[i, j, t] + $"({i},{j},{t})  ");//Выдаёт массив с индексом каждого элемента
            }
            Console.WriteLine();
        }         
    }
}

Fill3DArray(2,2,2);//Определяет размер массива
