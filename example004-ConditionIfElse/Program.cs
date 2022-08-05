Console.WriteLine("Enter user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yeah boy! It's Masha!");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}