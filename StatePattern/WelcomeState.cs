namespace StatePattern;

public class WelcomeState : SCState
{
    public WelcomeState(SelfCheckout selfCheckout) : base(selfCheckout)
    {
    }

    public override void OnScanningProduct(Product product)
    {
        Console.WriteLine($"Adding {product.Name} product to basket");
        SelfCheckout.ShoppingBasket.Products.Add(product);
        SelfCheckout.ChangeState(new ScanningState(SelfCheckout));
    }

    public override void OnNextClick()
    {
        Console.WriteLine($"Changing for {nameof(ScanningState)}");
        SelfCheckout.ChangeState(new ScanningState(SelfCheckout));
    }

    public override void OnPreviousClick()
    {
        Console.WriteLine($"Changing for {nameof(WelcomeState)}");
        SelfCheckout.ChangeState(new WelcomeState(SelfCheckout));
    }

    public override void OnPayForProduct()
    {
        Console.WriteLine($"You cant pay now - your are on Welcome Screen");
    }
}