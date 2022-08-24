public class SexRaiseCalculator : RaiseCalculator
{
    public override decimal CalculateRaise(Employee employee) => employee.IsFemale ? 300 : 0;
}