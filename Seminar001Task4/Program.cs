Console.Write("Введите первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int Num3 = Convert.ToInt32(Console.ReadLine());
if(Num1 > Num2)
{
    if(Num1 > Num3)
    {
     Console.Write("Максимум: ");
     Console.WriteLine(Num1);
     }
     else
     {
      Console.Write("Максимум: ");
      Console.WriteLine(Num3);
     }  
}
else
{
    if(Num2 > Num3)
    {
     Console.Write("Максимум: ");
     Console.WriteLine(Num2);
     }
     else
     {
      Console.Write("Максимум: ");
      Console.WriteLine(Num3);
     }
}

    

    