// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Проверяет, есть ли число
// string Check(int[] array, int num)
// {
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] == num)
//             return $"Есть, индекс {i}";
//     return "Нет";
// }
// // Выводит элементы массива в консоль
// void OutputArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length - 1] + "]");
// }

// int[] array = {1, -2, 5, 6, 58, 7, -3, -42, 63, 15};
// OutputArray(array);

// int num = Prompt("Введите число для поиска: ");

// Console.WriteLine(Check(array, num));

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

int[] array = RandomArray(12, -10, 10);
OutPutArray(array);
int num = ReadData("Введите число");
Console.WriteLine($"Число {num} встречается в массиве на {FindElement(array, num)} месте");