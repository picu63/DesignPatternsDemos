namespace FactoryMethodPattern;

public class PayPalGate : PaymentGate
{
    protected override void Process()
    {
        throw new NotImplementedException();
    }
}

public abstract class PaymentGate
{
    public void Pay(Order order)
    {
        var clientId = order.ClientId;

    }
    protected abstract void Process();
}