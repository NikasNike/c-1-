
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "nikita")
{
    Console.WriteLine("Ура, это же nikita");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
