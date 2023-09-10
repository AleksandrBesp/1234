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
Version2();
