Console.WriteLine("Введите имя пользователя: ");
string name = Console.ReadLine();

if(name.ToLower() == "иван")
    {
    Console.WriteLine("Ура, Иван");
} 
else
{
    Console.Write("Привет ");
    Console.WriteLine(name);
}