namespace MultipleDesignPatternsInOne;

public class LoginProcessor
{
    public Guid Login()
    {
        Console.WriteLine("Login in progress...");
        var loginToken = Guid.NewGuid();
        Console.WriteLine($"User is logged: {loginToken}");
        return loginToken;
    }
}