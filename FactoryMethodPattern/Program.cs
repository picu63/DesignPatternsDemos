// See https://aka.ms/new-console-template for more information

using FactoryMethodPattern;

Console.WriteLine("Factory Method");

var factories = new List<RaiseCalculator>() {new SeniorityRaiseCalculator(), new SexRaiseCalculator()};

var employees = new List<Employee>()
{
    new("Nick", 6, false),
    new("Natasha", 1, true),
    new("John Cena", 11, false),
};

foreach (var employee in employees)
{
    decimal basePayment = 3000;
    Console.WriteLine($"Initial {nameof(basePayment)} for {employee}: {basePayment}");
    foreach (var factory in factories)
    {
        Console.WriteLine($"Calculating raise for {employee} from {factory.CalculatorName}");
        var raise = factory.CalculateRaise(employee); // main factory method
        Console.WriteLine($"Raise calculated: {raise}");
        basePayment += raise;
        Console.WriteLine($"{nameof(basePayment)} increase to {basePayment}");
    }

    Console.WriteLine($"{employee} has {basePayment} after raises \n");
}