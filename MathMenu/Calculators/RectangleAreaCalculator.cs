namespace MathMenu;

/// <summary>
/// Rectangle Area Calculator
/// </summary>
public class RectangleAreaCalculator : IMathActionCalculator
{
    private readonly InputHelper _helper;

    public RectangleAreaCalculator(InputHelper helper)
    {
        _helper = helper;
    }

    /// <inheritdoc cref="IMathActionCalculator.MenuLine"/>
    public string MenuLine => "Посчитать площадь прямоугольника по заданным сторонам";

    /// <summary>
    /// Calculate Area for Rectangle with given side lengths
    /// </summary>
    /// <returns></returns>
    public double Calculate()
    {
        // reading both side legths
        var a = _helper.ReadDoubleFromConsole("a");
        var b = _helper.ReadDoubleFromConsole("b");

        return a * b;
    }
}