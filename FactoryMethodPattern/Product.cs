namespace FactoryMethodPattern;

public record Product(string Name, decimal Amount)
{
    public Guid Guid { get; } = Guid.NewGuid();
}