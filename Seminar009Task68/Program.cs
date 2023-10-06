// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
Console.WriteLine("Для расчёта функции Аккермана определите числа для расчёта.");

int m = ReadData("Введите число m :");
int n = ReadData("Введите число n :");
Console.WriteLine($"Итог функции Аккермана [ A({m},{n}) ] равен: ");
AkkermanFunction(m,n);



// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}