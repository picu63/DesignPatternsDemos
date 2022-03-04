namespace StatePattern;

public class PayState : SCState
{
    public PayState(SelfCheckout selfCheckout) : base(selfCheckout)
    {
    }
    public override string Name { get; protected set; } = nameof(PayState);

    public override void GoToNextState()
    {
        Console.WriteLine("You are on last screen");
    }

    public override void GoToPreviousState()
    {
        SelfCheckout.ChangeState(new ScanningState(SelfCheckout));
    }

    public override void OnPayment()
    {
        Console.WriteLine($"Paying for {SelfCheckout.ShoppingBasket.Products.Count} products");
    }
}