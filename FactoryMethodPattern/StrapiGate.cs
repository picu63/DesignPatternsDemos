namespace FactoryMethodPattern;

public class StrapiGate : PaymentGate
{
    protected override void Process()
    {
        throw new NotImplementedException();
    }
}