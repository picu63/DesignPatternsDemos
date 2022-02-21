namespace StatePattern;

public class PayState : SCState
{
    public PayState(SelfCheckout selfCheckout) : base(selfCheckout)
    {
    }

    public override void OnScanningProduct(Product product)
    {
        Console.WriteLine("You cannot scan product on Payment screen");
    }

    public override void OnNextClick()
    {
        Console.WriteLine("You are on last screen");
    }

    public override void OnPreviousClick()
    {
        SelfCheckout.ChangeState(new ScanningState(SelfCheckout));
    }

    public override void OnPayForProduct()
    {
        Console.WriteLine($"Paying for {SelfCheckout.ShoppingBasket.Products.Count} products");
    }
}