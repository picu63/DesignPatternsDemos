using MultipleDesignPatternsInOne.Orders;

namespace MultipleDesignPatternsInOne.Payments;

public interface IPaymentGateFactory
{
    IPaymentGate Create(PaymentGateType gateType);

}
public enum PaymentGateType
{
    Paypal,
    Strapi
}

class PaymentGateFactory : IPaymentGateFactory
{
    private readonly IOrderProvider orderProvider;

    public PaymentGateFactory(IOrderProvider orderProvider)
    {
        this.orderProvider = orderProvider;
    }
    public IPaymentGate Create(PaymentGateType gateType)
    {
        return gateType switch
        {
            PaymentGateType.Paypal => new PayPalGate(orderProvider),
            PaymentGateType.Strapi => new StrapiGate(orderProvider),
            _ => throw new ArgumentOutOfRangeException(nameof(gateType), gateType, null)
        };
    }
}