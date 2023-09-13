// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//     и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
//* Сделать вариант с использованием конструкции Dictionary
void Version1()
{
var Week = new Dictionary<int, string>()
{
    [1] ="Понедельник",
    [2] ="Вторник",
    [3] ="Среда",
    [4] ="Четверг",
    [5] ="Пятница",
    [6] ="Суббота",
    [7] ="Воскресенье",
};
var Weekend = new Dictionary<int, string>()
{
    [1] ="Рабочий",
    [2] ="Рабочий",
    [3] ="Рабочий",
    [4] ="Рабочий",
    [5] ="Рабочий",
    [6] ="Выходной",
    [7] ="Выходной",
};
Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Week[day] + " - " + Weekend[day]);
}
void Variant2()
{
    int GetNum()
{
    return Convert.ToInt32(Console.ReadLine());
}
// Получаем число и номер разряда
Console.Write("Введите число: ");
int num = GetNum();
Console.Write("Введите номер разряд: ");
int digit = GetNum();
// Метод для получения числа искомого разряда
int GetDigit(int num, int numOfDigit)
{
    while (num > Math.Pow(10, numOfDigit))
    {
        num /= 10;
    }
    return num = num % 10;
}
Console.WriteLine(num < Math.Pow(10, digit - 1) ? "Число меньше" : GetDigit(num, digit));
   
}
void Variant3()
{
    //                                        Домашнее задание к семинару 02
//                                                  Задача 13. 
//   Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//   * Сделать вариант для числа длиной до 10 цифр не используя char или string 
//------------------------------------------------------------------------------------------------------------------

Console.Clear();                    // Очистка терминала
int number, numberLenght;           // Объявление целочисленной переменной для числа и длины числа 
int index = 3;                      // Задаем индекс интересующей для вывода цифры (по условию это 3)

// Ввод числа пользователем
Console.Write("Введите положительное целое число, длинна которого не превышает 10 цифр: ");
while ((!(int.TryParse(Console.ReadLine(), out number))) || (!(number >= 0 && (numberLenght = (int)Math.Floor(Math.Log10(number) + 1)) <= 10)))
{ Console.Write("Неверный формат числа, попробуйте еще раз: "); }

// Проверка наличия третьей цифры в числе и вывод результата
Console.Write (numberLenght >= 3 
               ? number + " -> " + (number / (int)Math.Pow(10, numberLenght - index)) % 10 
               : "Третья цифра в числе отсутствует");
}