// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
GreetUser(name);

static void GreetUser(string name)
{
    Console.WriteLine($"Hello, {name}!");
}