// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6

// Заполняет массив случайными цифрами
double[] RandomArray(int num, int min, int max)
{
    double[] array = new double[num];
    for (int i = 0; i < num; i++)
        array[i] = new Random().Next(min, max) + Math.Round(new Random().NextDouble(),1);
    return array;
}

//Печать результата 
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
double Delta(double[] arr)
{
    double maxArr = arr[0];
    double minArr = arr[0];
    double delta = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > maxArr)
        {
            maxArr =  arr[i];
        }
        if(arr[i] < minArr)
        {
            minArr =  arr[i];
        }    
    }
    delta = maxArr - minArr;
    return delta;
}
double[]arr = RandomArray(10, -10, 10);
PrintArray(arr);
double delta = Delta(arr);
Console.WriteLine("Разница между максимальным и минимальным элементом массива составляет "+ delta);
