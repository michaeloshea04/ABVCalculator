//***Assume static main is here*******

// set up some variables for calculations
using ABVCalculator;

double startingSG = 0;
double endingSG = 0;


WelcomeMessage();
startingSG = AskUserForOriginalGravity(); // Add variable to contain starting Specific Gravity
endingSG = AskUserForFinalGravity(); // Add variable to contain ending Specific Gravity

// Call the calculator
var abv = Tools.CalculateAbv(startingSG, endingSG);


// Display the result of the calculation to the user
DisplayResult();

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
        string? userInput = Console.ReadLine(); // Allow the input to be nullable if the user just hits enter
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
        string? userInput = Console.ReadLine(); // Allow the input to be nullable if the user just hits enter
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

void DisplayResult()
{
    Console.WriteLine();
    Console.WriteLine("*************************************");
    Console.WriteLine($"* Alcohol by Volume is about {abv}%  *");
    Console.WriteLine("*************************************");
    Console.WriteLine();
}

static void FarewellMessage()
{
    Console.WriteLine("*************************************");
    Console.WriteLine("Thanks for using the ABV Calculator!!");
    Console.WriteLine("*************************************");
}