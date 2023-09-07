Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();
if(username.ToLower() == "sasha")
{
    Console.WriteLine("Ура, это же Sasha!");
}
else
{
       Console.Write("Привет, ");
       Console.WriteLine(username);
}