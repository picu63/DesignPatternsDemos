namespace StatePattern;

public class ScanningState : SCState
{
    public ScanningState(SelfCheckout selfCheckout) : base(selfCheckout)
    {
    }
    public override string Name { get; protected set; } = nameof(ScanningState);
    public override void OnScanningProduct(Product product)
    {
        Console.WriteLine($"Adding {product.Name} product to basket");
        SelfCheckout.ShoppingBasket.Products.Add(product);
    }

    public override void GoToNextState()
    {
        Console.WriteLine($"Changing for {nameof(PayState)}");
        SelfCheckout.ChangeState(new PayState(SelfCheckout));
    }

    public override void GoToPreviousState()
    {
        Console.WriteLine($"Changing for {nameof(WelcomeState)}");
        SelfCheckout.ChangeState(new WelcomeState(SelfCheckout));
    }

}