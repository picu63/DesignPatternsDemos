namespace StatePattern;

public class WelcomeState : SCState
{
    public WelcomeState(SelfCheckout selfCheckout) : base(selfCheckout)
    {
    }

    public override string Name { get; protected set; } = nameof(WelcomeState);

    public override void OnScanningProduct(Product product)
    {
        Console.WriteLine($"Adding {product.Name} product to basket");
        SelfCheckout.ShoppingBasket.Products.Add(product);
        SelfCheckout.ChangeState(new ScanningState(SelfCheckout));
    }

    public override void GoToNextState()
    {
        Console.WriteLine($"Changing for {nameof(ScanningState)}");
        SelfCheckout.ChangeState(new ScanningState(SelfCheckout));
    }

    public override void GoToPreviousState()
    {
        Console.WriteLine($"Changing for {nameof(WelcomeState)}");
        SelfCheckout.ChangeState(new WelcomeState(SelfCheckout));
    }
}