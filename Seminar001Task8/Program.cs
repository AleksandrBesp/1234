Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()??"0");
for (int i = 2; i <= N;i = i + 2)
{
    Console.Write($"{i}, ");
}