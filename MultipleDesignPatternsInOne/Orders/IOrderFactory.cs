namespace MultipleDesignPatternsInOne.Orders;

public interface IOrderFactory
{
    Order Create(Guid clientId, decimal amount);
}

public class OrderFactory : IOrderFactory
{
    private readonly IOrderProvider provider;

    public OrderFactory(IOrderProvider provider)
    {
        this.provider = provider;
    }
    public Order Create(Guid clientId, decimal amount)
    {
        var order = new Order() {ClientId = clientId, Cost = amount};
        provider.Add(order);
        return order;
    }
}