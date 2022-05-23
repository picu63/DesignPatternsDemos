namespace FactoryMethodPattern;

public class ShoppingBasketProcessor
{
    private readonly LoginProcessor loginProcessor;

    public ShoppingBasketProcessor(LoginProcessor loginProcessor)
    {
        this.loginProcessor = loginProcessor;
    }
    public void Process(ShoppingBasket shoppingBasket)
    {
        var clientId = loginProcessor.Login();
        var order = new Order(shoppingBasket.GetAmount(), clientId);

        Console.WriteLine("Select payment gate:");
        Console.WriteLine($"1. {nameof(PayPalGate)}");
        Console.WriteLine($"2. {nameof(StrapiGate)}");
        var keyInfo = Console.ReadKey();
        PaymentGate paymentGate;
        switch (keyInfo.KeyChar)
        {
            case '1':
                paymentGate = new PayPalGate();
                break;
            case '2':
                paymentGate = new StrapiGate();
                break;
        }
    }

    private void Pay(IPaymentGate paymentGate, Order order)
    {
        paymentGate.Process(order);
    }
}

public class LoginProcessor
{
    public Guid Login() => Guid.NewGuid();
}