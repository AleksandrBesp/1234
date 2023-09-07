Console.WriteLine("Введите число:");
double N = double.Parse(Console.ReadLine()??"0");
for (double i = 2; i <= N;i = i + 2)
{
    Console.Write($"{i}, ");
}