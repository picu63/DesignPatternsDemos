namespace FactoryMethodPattern.Orders;

public class Order
{
    public decimal Cost { get; init; }
    public Guid ClientId { get; init; }
    public Guid Id { get; } = Guid.NewGuid();
}