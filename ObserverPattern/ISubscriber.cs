public interface ISubscriber<in T>
{
    void ReceiveMessage(T message);
}