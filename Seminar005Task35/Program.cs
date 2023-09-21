// Задача №35
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Заполняет массив случайными цифрами
// int[] RandomArray()
// {
//     int[] randNums = new int[123];
//     for (int i = 0; i < randNums.Length; i++)
//         randNums[i] = new Random().Next(0, 200);
//     return randNums;
// }
// // Считает кол-во чисел 
// int CountElements(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//         if (array[i] >= 10 && array[i] <= 99) count++;

//     return count;
// }
// // Выводит элементы массива в консоль
// void OutputArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length - 1] + "]");
// }

// int[] array = RandomArray();
// OutputArray(array);
// Console.WriteLine($"Количество элементов массива в отрезке [10, 99]: {CountElements(array)}");

// //Евгений Гавриловец
// //Заполняем одномерный массив
// int[] GenArray(int num, int lowBorder, int highBorder)
// {

//     int[] array = new int[num];

//     for (int i = 0; i < num; i++)
//     {
//         array[i] = new Random().Next(lowBorder, highBorder + 1);
//     }

//     return array;
// }

// // Печатаем результат
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");

//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

// // Находим количество элементов в заданном диапазоне
// int CountElm(int[] arr, int x, int y)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         if (arr[i] > x && arr[i] < y)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// // Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
// int[] array = GenArray(123, 0, 30);
// PrintArray(array);
// int x = 10;
// int y = 99;
// int count = CountElm(array, x, y);
// PrintResult($"{count} элементов в заданном диапазоне");


//Иван Волков
int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int[] RandomArray(int len, int lowBorder, int highBorder){
    int[] rA = new int[len];
    for(int i = 0; i < len; i++)
    {
        rA[i] = new Random().Next(lowBorder, highBorder+1);
    }
    return rA;
}

void OutPutArray(int[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++){
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine( arr[arr.Length - 1] +"]");
}

int FindElement(int[] arr, int num)
{
    int pos = -1;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num){
            pos = i;
            return pos;
        }
    }
    return pos;
}

int CountElDiapason(int[] arr, int min, int max)
{
    int count = 0;
    if(min > max){
        int temp = min;
        min = max;
        max = min;
    }
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= min && arr[i] <= max){
            count++;
        }
    }
    return count;
}

int[] array = RandomArray(123, 0, 1000);
OutPutArray(array);
int count = CountElDiapason(array, 10,99);
Console.WriteLine($"Количество элементов удовлетворяющих условию: { count}");