// See https://aka.ms/new-console-template for more information

// variable for reading key at the end of the loop

ConsoleKeyInfo keyPressed;

// loop to be able to restart logic after finish
do
{
    // clear screen after prev. run
    Console.Clear();

    // hint for input
    Console.Write("Give me month number (1 <= number <= 12): ");

    // reading user input
    string? input = Console.ReadLine();

    byte monthNumber;

    // input validation inside loop, to be able to retry input in case if it was invalid
    //while (!byte.TryParse(input, out monthNumber) || monthNumber < 1 || monthNumber > 12)
    while (!byte.TryParse(input, out monthNumber) || monthNumber is < 1 or > 12)
    {
        Console.WriteLine("Invalid month number. Try again!");

        Console.Write("Give me month number (1 <= number <= 12): ");

        // read input again
        input = Console.ReadLine();
    }

    // just empty line 
    Console.WriteLine();

    // checking month number
    switch (monthNumber)
    {
        // Winter (Month is 12 or Month < 3)
        case < 3:
        case 12:
            Console.WriteLine("It's Winter, dress warm.");
            break;
        // Spring (2 > Month > 6)
        case > 2 and < 6:
            Console.WriteLine("It's Spring! The weather is getting better.");
            break;
        // Summer (5 > Month > 9)
        case > 5 and < 9:
            Console.WriteLine("It's Summer. So hot!");
            break;
        // Summer (8 > Month > 12)
        case > 8 and < 12:
            Console.WriteLine("It's Autumn...Wake me up when September ends...");
            break;
        // we will never reach here, but just in case we show some message
        default:
            Console.WriteLine("Smth went wrong, unknown month!");
            break;
    }

    // explaining user what to do
    Console.WriteLine("\nPress any key to continue. Press ESC to exit.");

    keyPressed = Console.ReadKey();

    // repeat look until key is not Escape
} while (keyPressed.Key != ConsoleKey.Escape);