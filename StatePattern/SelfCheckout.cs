// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace StatePattern;

public class SelfCheckout
{
    public SCState State { get; private set; }

    internal void SummaryShoppingBasket()
    {
        State.OnPayment();
    }

    public Basket ShoppingBasket { get; set; } = new();

    public SelfCheckout()
    {
        Console.WriteLine($"Initializing {nameof(SelfCheckout)}");
        State = new WelcomeState(this);
    }
    public void ScanProduct(Product product)
    {
        State.OnScanningProduct(product);
    }

    public void OnPreviousClick()
    {
        State.GoToPreviousState();
        Console.WriteLine($"Current state is {State.Name}");
    }

    public void OnNextClick()
    {
        State.GoToNextState();
        Console.WriteLine($"Current state is {State.Name}");
    }

    public void ChangeState(SCState state)
    {
        State = state;
    }
}

public class Basket
{
    public IList<Product> Products { get; set; } = new List<Product>();
}

public record Product(string Name);