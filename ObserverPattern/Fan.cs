public class Fan : IMessageSubscriber
{
    public Fan(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{FirstName} {LastName} received a message: {message}");
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}