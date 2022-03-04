using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//Stary kod który musimy podmienić
//using IHost host = Host.CreateDefaultBuilder(args)
//    .ConfigureServices((_, services) =>
//        services
//            .AddScoped<IExternalRunner, ExternalRunner>())
//        .Build();

// W tym przypadku wszystkie inne klasy które dziedziczą z IExternalRunner będą teraz wywoływać najpierw Check przed Run
using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services
            .AddScoped<IExternalRunner, CheckExternalRunner>()
            .AddScoped<ExternalRunner>())
        .Build();

host.Services.GetService<IExternalRunner>().Run();

public interface IExternalRunner
{
    void Run();
}


// !!! SEALED !!! - so we cannot just simply override run method
public sealed class ExternalRunner : IExternalRunner
{
    public void Run()
    {
        Console.WriteLine($"Running code from {nameof(ExternalRunner)}"); // cannot be changed
    }
}

public class CheckExternalRunner : IExternalRunner
{
    private readonly ExternalRunner externalRunner;
    public CheckExternalRunner(ExternalRunner externalRunner)
    {
        this.externalRunner = externalRunner;
    }

    private void Check()
    {
        Console.WriteLine("Checking something");
    }

    public void Run()
    {
        Console.WriteLine($"{nameof(Run)} from {nameof(CheckExternalRunner)}");
        Check();
        externalRunner.Run();
    }
}