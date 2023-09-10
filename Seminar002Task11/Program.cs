// Задача №11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void Variant1()
{
int ran = new System.Random().Next(100, 1000);
    System.Console.WriteLine(ran);
    char[] digitChar = ran.ToString().ToCharArray();
    System.Console.Write(digitChar[0]);
    System.Console.Write(digitChar[2]);

    start:

Console.WriteLine("Чтобы выйти введите -1");
Console.Write("Введите число: ");
string stringNum = Console.ReadLine()??"0";
int num = Convert.ToInt32(stringNum);

if (num == -1) return;
if (stringNum.Length != 3)
    Console.WriteLine("Число не трёхзначное");
else
{
    Console.WriteLine((num / 100) * 10 + (num % 10));
}

// Console.WriteLine(stringNum.Length != 3 ? "Число не трёхзначное" : (num / 100) * 10 + (num % 10));

Console.WriteLine();

goto start;
}
void Variant2()
{
int number = new  Random().Next(100, 1000);
Console.WriteLine(number);

int firstDigit = number/100;
int lastDigit = number%10;
number = firstDigit*10 + lastDigit;

Console.WriteLine(number);
}
void Variant3()
{
System.Random numberGenerator = new System.Random();
 int Number = numberGenerator.Next(10,1000);
 Console.WriteLine(Number);
 char[] digitChar = Number.ToString().ToCharArray();
 string NewNumber = ((string.Concat(digitChar[0].ToString(),digitChar[2].ToString()).ToString()));
 Console.WriteLine(NewNumber);



 System.Random numberGenerator = new System.Random();

int n = numberGenerator.Next(0,100);
int maxDigit = n%10;
Console.WriteLine(n);
while(n > 0){
 if(n%10 > maxDigit){
    maxDigit = n % 10;
 }
 n/=10;
}
Console.WriteLine(maxDigit);
}

 Variant1();