// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1

//Cоздаём массив
int[] GenArray(int num, int numMin, int numMax){
    
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(numMin, numMax);
    }

    return array;
}


//Печать результата 
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Подсчёт количества чётных чисел в массиве.
int CountEvn(int[]arr)
{
    int count = 0;
    for(int i = 0 ; i < arr.Length; i++)
    {
        if(arr[i]%2==0)
        {
            count++;
        }     
    }
    return count; 
    
}

int[]arr = GenArray(12,100,999);
PrintArray(arr);
int count = CountEvn(arr);
Console.WriteLine("Количество чётных чисел в массиве равно "+ count);