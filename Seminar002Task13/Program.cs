//№13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//* Сделать вариант для числа длиной до 10 цифр не используя char или string
void Version1()
{
Console.Write("Введите число: ");
string? numLine = Console.ReadLine();
char[] digits = numLine.ToCharArray();
Console.WriteLine("Третьей цифрой числа является: ");
Console.WriteLine(digits[2]);
}
void Version2()
{
Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int NumMin = 100;
int NumMax = 999;
if(numbers < NumMin)
{
 Console.WriteLine("Число не является трёхзначным.");
}
else
{
    while(numbers>NumMax)
    {
        numbers = numbers / 10;
    }
    numbers = numbers % 10;
    Console.WriteLine(numbers);
}
}

void Variant3()
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
void Variant4()
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
Version2();
