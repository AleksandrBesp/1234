// Задание №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру.
Console.Write("Введите трёхзначное число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
int Num1 = Num2/100;
int Num3 = Num2%10;
int NumMax = 999;
if(Num2>NumMax)
{
    Console.WriteLine("Число содержит больше трёх знаков!");
}
if(Num1 == 0)
{
    Console.WriteLine("Число содержит меньше трёх знаков!");
}
Num2 = (Num2 - (Num1*100 + Num3))/10;
Console.WriteLine(Num2);
