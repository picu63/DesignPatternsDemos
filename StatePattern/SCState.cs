namespace StatePattern;

public abstract class SCState
{
    protected SCState(SelfCheckout selfCheckout)
    {
        SelfCheckout = selfCheckout;
    }
    public abstract string Name { get; protected set; }
    protected SelfCheckout SelfCheckout { get; set; }

    public abstract void GoToNextState();

    public abstract void GoToPreviousState();

    public virtual void OnScanningProduct(Product product)
    {
        Console.WriteLine($"You cannot scan product on this {Name}");
    }

    public virtual void OnPayment()
    {
        Console.WriteLine($"You cant pay now - your are in {Name}");
    }
}