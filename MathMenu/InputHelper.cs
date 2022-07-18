namespace MathMenu;

/// <summary>
/// Input helper encapsulates user input from console 
/// </summary>
public class InputHelper
{
    /// <summary>
    /// Reading Double Number from Console
    /// </summary>
    /// <param name="name">Name of the expected number (for user hint)</param>
    /// <param name="minVal">Min value for validation</param>
    /// <returns>Number</returns>
    public double ReadDoubleFromConsole(string name, double minVal = 0d)
    {
        Console.Write("Введите {0} ({0} > {1}): ", name, minVal);

        // first read
        var stringInput = Console.ReadLine();

        double result;

        // if it's not a number or number is less than minimal value
        while (!double.TryParse(stringInput, out result) || result < minVal)
        {
            // try again
            Console.Write("Некорректный ввод, попробуйте еще: ");

            stringInput = Console.ReadLine();
        }

        return result;
    }
}