internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите имя пользователя: ");
        string username = Console.ReadLine();

        if (username.ToLower() == "марк")
        {
            Console.WriteLine("Ура, это же МАРК!");
        }
        else
        {
            Console.Write("Привет, ");
            Console.WriteLine(username);
        }
    }
}