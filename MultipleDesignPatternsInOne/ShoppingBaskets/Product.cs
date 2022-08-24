namespace MultipleDesignPatternsInOne.ShoppingBaskets;

public record Product(string Name, decimal EntityPrice)
{
    public Guid Guid { get; } = Guid.NewGuid();
    public override string ToString()
    {
        return $"{Name}({EntityPrice}PLN)";
    }
}