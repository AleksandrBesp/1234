﻿// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
void Variant1()
{
    Console.WriteLine("Способ 1");

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    //34
    //34/10 = 3
    int firstDigit = number / 10;
    //34%10 = 4
    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void Variant2()
{
    Console.WriteLine("Способ 2");

    System.Random numberGenerator1 = new System.Random();
    int number1 = numberGenerator1.Next(10, 100);
    Console.WriteLine(number1);
}
void Variant3()
{
    Console.WriteLine("Способ 3");

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    char[] digitChar = number.ToString().ToCharArray();
    Console.WriteLine((int)digitChar[0]>(int)digitChar[1]?digitChar[0]:digitChar[1]);
    //<условие>?<вариант1>:<вариант2>

}

void VariantMM()
{
using System;

int randomNum = new Random().Next(10, 99);

Console.WriteLine(randomNum);
}

void VariantIV()
{
Console.WriteLine("Способ Ивана Волкова");

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

