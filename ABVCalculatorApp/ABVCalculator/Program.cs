
WelcomeMessage();

AskUserForOG();

Console.ReadLine();

static void WelcomeMessage()
{
    Console.WriteLine("*******************************");
    Console.WriteLine("Welcome to the ABV Calculator!!");
    Console.WriteLine("*******************************");
}

static double AskUserForOG()
{
    bool isValid;
    double output = 0;

    Console.Write("Please enter your original gravity: ");
    string userInput = Console.ReadLine();
    isValid = double.TryParse(userInput, out output); 

    return output;
    

}
