// Задача №12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если второе число некратно первому, 
//то программа выводит остаток от деления.
void Variant1()
{
int f = int.Parse(Console.ReadLine()??"0");
int s = int.Parse(Console.ReadLine()??"0");

Console.WriteLine((s%f==0)?true:s%f);
}

void Variant2()
{
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(num2%num1==0?"Второе число кратно первому":"Остаток от деления: " + (num2%num1));
}

void Variant3()
{
int first = int.Parse(Console.ReadLine() ?? "0");
int second = int.Parse(Console.ReadLine() ?? "0");
String result = (first%second == 0) ? "Второе кратно первому" : "Второе не кратно первому";
System.Console.WriteLine(result + ". Остаток от деления: " + first%second);
}