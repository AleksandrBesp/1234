// Задание №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру.
Console.Write("Введите трёхзначное число: ");
int Numb = Convert.ToInt32(Console.ReadLine());

int firstDigit = Numb/100;
int lastDigit = Numb%10;
Numb = (Numb - (firstDigit*100 + lastDigit))/10;

Console.WriteLine(Numb);