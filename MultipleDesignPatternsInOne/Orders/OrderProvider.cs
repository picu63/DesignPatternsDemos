namespace MultipleDesignPatternsInOne.Orders;

public class OrderProvider : IOrderProvider
{
    private readonly IList<Order> _orders = new List<Order>();
    private static readonly Lazy<OrderProvider> LazyProvider = new();
    public IOrderProvider Instance => LazyProvider.Value;

    public void Add(Order order)
    {
        _orders.Add(order);
    }

    public Order GetOrder(Guid orderId)
    {
        return _orders.First(o => o.Id == orderId);
    }
}