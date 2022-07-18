namespace MathMenu;

/// <summary>
/// Square Area Calculator
/// </summary>
public class SquareAreaCalculator : IMathActionCalculator
{
    private readonly InputHelper _helper;

    public SquareAreaCalculator(InputHelper helper)
    {
        _helper = helper;
    }

    /// <inheritdoc cref="IMathActionCalculator.MenuLine"/>
    public string MenuLine => "Посчитать площадь квадрата по заданной стороне";

    /// <summary>
    /// Calculate Area for Square with given side length
    /// </summary>
    /// <returns>Area value</returns>
    public double Calculate()
    {
        // reading side length using InputHelper
        var a = _helper.ReadDoubleFromConsole("a");
        
        return a * a;
    }
}