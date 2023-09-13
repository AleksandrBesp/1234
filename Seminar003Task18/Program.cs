//Задача №18
//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек
// в этой четверти (x и y).


// Вывод сообщения и вызов метода CheckingCoordinates
string Prompt(string message)
{
    Console.WriteLine(message);
    string values = Console.ReadLine()??",";
    int quarter = Convert.ToInt32(values);

    return CheckingCoordinates(quarter);
}

// Проверка четверти
string CheckingCoordinates(int quarter)
{
    switch(quarter)
    {
        case 1: return "(X > 0 ; Y > 0)";
        case 2: return "(X < 0 ; Y > 0)";
        case 3: return "(X < 0 ; Y < 0)";
        case 4: return "(X > 0 ; Y < 0)";
        default: return "0";
    }
}
Console.WriteLine(Prompt("Введите номер четверти: "));

void ShowInterval(int q){
    String x;
    String y;
    if (q < 1|| q> 4) Console.WriteLine("Something went wrong");
    if (q == 1|| q == 4){
        x = "[0:inf]";
    }
    else
        x = "[-inf:0]";

    if (q ==1||q ==2){
        y = "[0:inf]";
    }
    else y = "[-inf:0];";

    Console.WriteLine("x: "+ x+ " y: " +y);
}



int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

string QuterBorderAsk(int numQuter) // по координатам точки определяем номер четверти
{
    if(numQuter == 1) return "x > 0 и y > 0";
    if(numQuter == 2) return "x < 0 и y > 0";
    if(numQuter == 3) return "x < 0 и y < 0";
    if(numQuter == 3) return "x > 0 и y < 0";
    return "empty";
}

void PrintResult(string msg) // печатаем результат
{
    Console.WriteLine("Координаты находятся в диапазоне следующих значений: "+ msg);
}