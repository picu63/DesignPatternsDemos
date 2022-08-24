using FactoryMethodPattern.Orders;

namespace FactoryMethodPattern.Payments;

public class PayPalGate : PaymentGate
{
    public PayPalGate(IOrderProvider orderProvider) : base(orderProvider)
    {
    }

    protected override bool Pay(decimal amount)
    {
        Console.WriteLine($"Going to {nameof(PayPalGate)} site");
        Console.WriteLine($"Process payment {amount}");
        var isSucceeded = Random.Shared.Next(0, 1) == 1;
        return isSucceeded;
    }
}