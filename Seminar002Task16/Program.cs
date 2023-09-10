// Задача №16. Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
void Variant1(){
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine() ?? "0");

bool test1 = (num1 == num2*num2);
bool test2 = (num2 == num1*num1);

Console.WriteLine((test1 || test2) ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");
}
void Variant2(){
int first_number = int.Parse(Console.ReadLine()??"0");
int second_number = int.Parse(Console.ReadLine()??"0");

Console.WriteLine(first_number > second_number? (first_number ^ (second_number*second_number))==0:(second_number ^ (first_number*first_number))==0);
}
void Variant3(){

int GetNum(){
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int firstNum = GetNum();
int secondNum = GetNum();

bool firstPow = firstNum == Math.Pow(secondNum, 2);
bool secondPow = secondNum == Math.Pow(firstNum, 2);


Console.WriteLine(firstPow  || secondPow ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");
}
void Variant4(){
int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");

bool test1 = a == b*b;
bool test2 = b == a*a;

if(test1){
    Console.WriteLine("Первое квадрат второго");
}else if(test2){
    Console.WriteLine("Второе квадрат первого");
}else{
    Console.WriteLine("Одно не является квадратом другого");
}
}