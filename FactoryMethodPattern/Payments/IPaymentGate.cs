using FactoryMethodPattern.Orders;

namespace FactoryMethodPattern.Payments;

public interface IPaymentGate
{
    PaymentStatus ProcessPayment(Guid orderId);

}
public enum PaymentStatus
{
    Succeeded,
    Failed,
}