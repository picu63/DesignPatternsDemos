namespace FactoryMethodPattern;

public interface IPaymentGate
{
    void Process(Order order);
}