namespace MathMenu;

/// <summary>
/// Cos Calculator
/// </summary>
public class CosCalculator : IMathActionCalculator
{
    private readonly InputHelper _inputHelper;

    public CosCalculator(InputHelper inputHelper)
    {
        _inputHelper = inputHelper;
    }

    /// <inheritdoc cref="IMathActionCalculator.MenuLine"/>
    public string MenuLine => "Найти косинус угла по заданному углу";

    /// <summary>
    /// Calculate Cos for given angle
    /// </summary>
    /// <returns></returns>
    public double Calculate()
    {
        // read angle degree using InputHelper
        var degrees = _inputHelper.ReadDoubleFromConsole("Угол (градусы)");

        // convert degree to radians
        double angle = Math.PI * degrees / 180.0;

        // calculate Cos and return
        return Math.Cos(angle);
    }
}