using MultipleDesignPatternsInOne.Orders;
using MultipleDesignPatternsInOne.Payments;

namespace MultipleDesignPatternsInOne.ShoppingBaskets;

public class ShoppingBasketProcessor
{
    private readonly LoginProcessor loginProcessor;
    private readonly IOrderFactory orderFactory;
    private readonly IOrderProvider orderProvider;

    public ShoppingBasketProcessor(LoginProcessor loginProcessor, IOrderFactory orderFactory, IOrderProvider orderProvider)
    {
        this.loginProcessor = loginProcessor;
        this.orderFactory = orderFactory;
        this.orderProvider = orderProvider;
    }
    public void Process(ShoppingBasket shoppingBasket)
    {
        Console.WriteLine($"Processing shopping basket: {shoppingBasket.Id}");
        var clientId = loginProcessor.Login();
        var order = orderFactory.Create(clientId, shoppingBasket.GetAmount());

        Console.WriteLine("Select payment gate:");
        Console.WriteLine($"1. {nameof(PaymentGate)}");
        Console.WriteLine($"2. {nameof(StrapiGate)}");
        var keyInfo = Console.ReadKey();
        PaymentGate paymentGate = null;
        switch (keyInfo.KeyChar)
        {
            case '1':
                paymentGate = new PayPalGate(orderProvider);
                break;
            case '2':
                paymentGate = new StrapiGate(orderProvider);
                break;
        }

        if (paymentGate is null)
        {
            Console.WriteLine("Payment gate have to be selected");
            return;
        }

        var result = paymentGate.ProcessPayment(order.Id);
        Console.WriteLine($"Process of payment via payment gate: {result}");
    }
}