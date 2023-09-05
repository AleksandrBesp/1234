Console.WriteLine("Введите три числа:");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());
int Num3 = Convert.ToInt32(Console.ReadLine());
if(Num1 < Num2)
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

    

    