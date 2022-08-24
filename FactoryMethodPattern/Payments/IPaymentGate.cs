namespace MultipleDesignPatternsInOne.Payments;

public interface IPaymentGate
{
    PaymentStatus ProcessPayment(Guid orderId);

}
public enum PaymentStatus
{
    Succeeded,
    Failed,
}