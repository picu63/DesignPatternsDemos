public interface ISubscriberService<T>
{
    List<T> Subscribers { get; }
    void AddSubscriber(T subscriber);
    void RemoveSubscriber(T subscriber);
    void NotifySubscribers();
}