using FactoryMethodPattern.Orders;

namespace FactoryMethodPattern.Payments;

public abstract class PaymentGate : IPaymentGate
{
    private readonly IOrderProvider orderProvider;

    protected PaymentGate(IOrderProvider orderProvider)
    {
        this.orderProvider = orderProvider;
    }
    public PaymentStatus ProcessPayment(Guid orderId)
    {
        var order = orderProvider.GetOrder(orderId);

        return Pay(order.Cost) ? PaymentStatus.Succeeded : PaymentStatus.Failed;
    }
    protected abstract bool Pay(decimal amount);
}