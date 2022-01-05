//***Assume static main is here*******
WelcomeMessage();
AskUserForOriginalGravity();
AskUserForFinalGravity();
//TODO Insert Return of ABV calc
FarewellMessage();

Console.ReadLine();

//***Assume static main is here*******

static void WelcomeMessage()
{
    Console.WriteLine("*******************************");
    Console.WriteLine("Welcome to the ABV Calculator!!");
    Console.WriteLine("*******************************");
}

static double AskUserForOriginalGravity()
{
    //variables to be used in do-while loop
    bool isValid;
    double output = 0;

    do
    {
        Console.Write("Please enter your original gravity: ");
        string userInput = Console.ReadLine();
        isValid = double.TryParse(userInput, out output);

        if (isValid == false)
        {
            Console.WriteLine("That is an invalid gravity entry.");
            Console.WriteLine("Please try again.");
            Console.WriteLine();
        }

    } while (isValid == false);

    Console.WriteLine();
    Console.WriteLine($"You have entered {output} as your original gravity.");
    Console.WriteLine();

    return output;
    

}

static double AskUserForFinalGravity()
{
    //variables to be used in do-while loop
    bool isValid;
    double output = 0;

    do
    {
        Console.Write("Please enter your final gravity: ");
        string userInput = Console.ReadLine();
        isValid = double.TryParse(userInput, out output);

        if (isValid == false)
        {
            Console.WriteLine("That is an invalid gravity entry.");
            Console.WriteLine("Please try again.");
            Console.WriteLine();
        }

    } while (isValid == false);

    Console.WriteLine();
    Console.WriteLine($"You have entered {output} as your final gravity.");
    Console.WriteLine();
    
    return output;


}

//TODO Create data table to use in ABV lookup

//TODO Create logic to retrieve ABV value

static void FarewellMessage()
{
    Console.WriteLine("*************************************");
    Console.WriteLine("Thanks for using the ABV Calculator!!");
    Console.WriteLine("*************************************");
}