namespace MathMenu;

/// <summary>
/// Interface that groups all calculators with a single schema
/// </summary>
public interface IMathActionCalculator
{
    /// <summary>
    /// Menu line to print
    /// </summary>
    public string MenuLine { get; }
    
    /// <summary>
    /// Calculation logic
    /// </summary>
    /// <returns>Calculation result</returns>
    public double Calculate();
}