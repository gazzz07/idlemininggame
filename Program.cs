Console.WriteLine("Welcome to IdleMiner! Please enter your name...");
string playerName = Console.ReadLine();

Console.WriteLine($"Hello {playerName}. Please select from the following...");
Console.WriteLine("1 - New Game\t2 - Exit");
string menuInput = Console.ReadLine();

if (menuInput == "1")
{
    Console.WriteLine("Let's begin!");
}
else if (menuInput == "2")
{
    Console.WriteLine("Goodbye!");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Invalid input, please select from the following...");
    //Put this menu into a class and call here.
    Environment.Exit(0);
}
