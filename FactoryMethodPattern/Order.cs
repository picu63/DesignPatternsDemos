namespace FactoryMethodPattern;

public class Order
{
    public Order(decimal cost, Guid clientId)
    {
        Cost = cost;
        ClientId = clientId;
    }

    public decimal Cost { get; }
    public Guid ClientId { get; }
    public Guid Guid { get; } = Guid.NewGuid();
}