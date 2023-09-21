// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine()??",";
    int number = Convert.ToInt32(value);

    return number;
}

// Заполняет массив случайными цифрами
int[] RandomArray(int count, int min, int max)
{
    int[] randNums = new int[count];
    for (int i = 0; i < randNums.Length; i++)
        randNums[i] = new Random().Next(min, max);
    return randNums;
}

// Выводит элементы массива в консоль
void OutputArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine(array[array.Length - 1] + "]");
}


// Определение чётных позиций массива и суммы их значений
int SumEvnArray (int[] array)
{
    int sumEvnArr = 0;
    int count = array.Length;
    
    for (int i = 1; i < count; i = i + 2)
    {
        sumEvnArr = array[i] + sumEvnArr;
    }
    return sumEvnArr;
}

//Вывод информации
int count = Prompt("Введите размер массива: ");
int[] array = RandomArray(count, -100, 100);
Console.Write("Массив: ");
OutputArray(array);
int sumEvnArr = SumEvnArray(array);
Console.Write("Сумма элементов, стоящих на нечётных позициях составляет: "+ sumEvnArr);
