namespace FactoryMethodPattern.Orders;

public interface IOrderProvider
{
    IOrderProvider Instance { get; }
    void Add(Order order);
    Order GetOrder(Guid orderId);
}