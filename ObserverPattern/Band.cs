public class Band : IFanSubscriberService
{
    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public string Status { get; private set; }
    public void PlayMusic()
    {
        Status = $"{Name} is currently playing.";
        NotifySubscribers();
    }

    public void StopPlay()
    {
        Status = $"{Name} stopped play.";
        NotifySubscribers();
    }

    public List<Fan> Subscribers { get; } = new();

    public void AddSubscriber(Fan subscriber)
    {
        Console.WriteLine($"New subscriber added to {Name}: {subscriber}");
        Subscribers.Add(subscriber);
    }

    public void RemoveSubscriber(Fan subscriber)
    {
        Console.WriteLine($"Subscriber removed from {Name}: {subscriber}");
        Subscribers.Remove(subscriber);
    }

    public void NotifySubscribers()
    {
        foreach (var subscriber in Subscribers)
        {
            subscriber.ReceiveMessage(Status);
        }
    }
}