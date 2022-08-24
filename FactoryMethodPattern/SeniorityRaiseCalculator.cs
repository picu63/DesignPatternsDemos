namespace FactoryMethodPattern;

public class SeniorityRaiseCalculator : RaiseCalculator
{
    public override decimal CalculateRaise(Employee employee)
    {
        return employee.SeniorityInYears switch
        {
            > 0 and < 2 => 0,
            >= 2 and < 5 => 500,
            >= 5 and < 10 => 800,
            >= 10 => 2000,
            _ => throw new ArgumentOutOfRangeException(nameof(employee.SeniorityInYears))
        };
    }
}