public abstract class RaiseCalculator
{
    public string CalculatorName => this.GetType().Name;
    public abstract decimal CalculateRaise(Employee employee);
}