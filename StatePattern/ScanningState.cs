namespace StatePattern;

public class ScanningState : SCState
{
    public ScanningState(SelfCheckout selfCheckout) : base(selfCheckout)
    {
    }

    public override void OnScanningProduct(Product product)
    {
        Console.WriteLine($"Adding {product.Name} product to basket");
        SelfCheckout.ShoppingBasket.Products.Add(product);
    }

    public override void OnNextClick()
    {
        Console.WriteLine($"Changing for {nameof(PayState)}");
        SelfCheckout.ChangeState(new PayState(SelfCheckout));
    }

    public override void OnPreviousClick()
    {
        Console.WriteLine($"Changing for {nameof(WelcomeState)}");
        SelfCheckout.ChangeState(new WelcomeState(SelfCheckout));
    }

    public override void OnPayForProduct()
    {
        Console.WriteLine("Please click next to pay for product..");
    }
}