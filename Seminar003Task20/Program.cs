//Задача №20
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 2D пространстве.


// Вывод сообщения и вызов метода DistanceCalculation
//double Prompt(string message1, string message2){
//     Console.WriteLine(message1);
//     string values = Console.ReadLine()??",";

//     values += ",";

//     Console.WriteLine(message2);
//     values += Console.ReadLine()??",";

//     string[] valuesArray = values.Split(",");
//     int xA = Convert.ToInt32(valuesArray[0]);
//     int yA = Convert.ToInt32(valuesArray[1]);
//     int xB = Convert.ToInt32(valuesArray[2]);
//     int yB = Convert.ToInt32(valuesArray[3]);

//     return DistanceCalculation(xA, yA, xB, yB);
// }

// Расчёт расстояния
//double DistanceCalculation(int xA, int yA, int xB, int yB)
// {
//     return Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2) + Math.Pow(Math.Abs(yA - yB), 2));
// }

//Console.WriteLine(Prompt("Введите 2 числа через запятую (координаты первой точки): ", "Введите 2 числа через запятую (координаты второй точки): "));




// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// double Distance(int x,int y)
// {
//     double distance = Math.Sqrt(x*x+y*y);
//     return distance;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int x1 = ReadData("Введите координату x1: ");
// int y1 = ReadData("Введите координату y1: ");
// int x2 = ReadData("Введите координату x2: ");
// int y2 = ReadData("Введите координату y2: ");
// double res = Distance((x2-x1),(y2-y1));
// PrintResult("Расстояние равно " + $"{res}");

double Prompt(string message1)
{
    Console.WriteLine(message1);
    string values = Console.ReadLine()??",";

    string[] valuesArray = values.Split(",");
    int xA = Convert.ToInt32(valuesArray[0]);
    int yA = Convert.ToInt32(valuesArray[1]);
    int zA = Convert.ToInt32(valuesArray[2]);
    int xB = Convert.ToInt32(valuesArray[3]);
    int yB = Convert.ToInt32(valuesArray[4]);
    int zB = Convert.ToInt32(valuesArray[5]);

    return DistanceCalculation(xA, yA, zA, xB, yB, zB);
}


//A (3,6,8); B (2,1,-7)
// Расчёт расстояния
double DistanceCalculation(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(Math.Abs(xA - xB), 2)
                    + Math.Pow(Math.Abs(yA - yB), 2)
                    + Math.Pow(Math.Abs(zA - zB), 2));
}

Console.WriteLine(Prompt("Введите 6 чисел через запятую (xA,yA,zA,xB,yB,zB): "));

