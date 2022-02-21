namespace StatePattern;

public abstract class SCState
{
    protected SCState(SelfCheckout selfCheckout)
    {
        SelfCheckout = selfCheckout;
    }

    protected SelfCheckout SelfCheckout { get; set; }
    public abstract void OnScanningProduct(Product product);
    public abstract void OnNextClick();
    public abstract void OnPreviousClick();
    public abstract void OnPayForProduct();
}