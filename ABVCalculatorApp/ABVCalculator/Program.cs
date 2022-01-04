
WelcomeMessage();

AskUserForOG();

Console.ReadLine();

static void WelcomeMessage()
{
    Console.WriteLine("*******************************");
    Console.WriteLine("Welcome to the ABV Calculator!!");
    Console.WriteLine("*******************************");
}

static void AskUserForOG()
{
    Console.Write("Please enter your original gravity: ");
    string userInput = Console.ReadLine();
}
