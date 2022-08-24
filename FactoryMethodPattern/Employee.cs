namespace FactoryMethodPattern;

public record Employee(string Name, int SeniorityInYears, bool IsFemale)
{
    public override string ToString() => Name;
}