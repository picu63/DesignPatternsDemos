// See https://aka.ms/new-console-template for more information
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2)
{
    Console.WriteLine("Instances are the same");
}


public class Logger
{
    private static readonly Lazy<Logger> LazyLogger = new(() => new Logger());
    public static Logger Instance => LazyLogger.Value;
}