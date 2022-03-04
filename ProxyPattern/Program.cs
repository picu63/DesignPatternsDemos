using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//Stary kod który musimy podmienić
//using IHost host = Host.CreateDefaultBuilder(args)
//    .ConfigureServices((_, services) =>
//        services
//            .AddScoped<IExternalRunner, ExternalRunner>())
//        .Build();
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


// !!! SEALED !!!
public sealed class ExternalRunner : IExternalRunner
{
    public void Run()
    {
        Console.WriteLine("Running old code that cannot be changed");
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
        Check();
        externalRunner.Run();
    }
}