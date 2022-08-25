// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;

Console.WriteLine("Prototype Pattern");

var manager = new Manager("Cindy");
var managerClone = (Manager)manager.Copy();
Console.WriteLine($"Manager was cloned: {managerClone.Name}");

var employee = new Employee("Kevin", manager);
var employeeClone = (Employee)employee.Copy(true);
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

// change the manager name
managerClone.Name = "Karen";
Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");

Console.ReadKey();

public abstract class Person
{
    public abstract string Name { get; set; }

    public abstract Person Copy(bool deepClone);

}

public class Employee : Person, ICloneable
{
    public Manager Manager { get; set; }
    public override string Name { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public override Person Copy(bool deepClone)
    {
        if (!deepClone) return (Person)MemberwiseClone();

        var settings = new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All};
        var objectAsJson = JsonConvert.SerializeObject(this, typeof(Employee), settings);
        return JsonConvert.DeserializeObject<Person>(objectAsJson, settings);
    }

    public object Clone()
    {
        throw new NotImplementedException(); // can be used, but don't have option for deep copy
    }
}

public class Manager : Person
{
    public override string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }

    public override Person Copy(bool deepClone = default)
    {
        if (!deepClone) return (Person) MemberwiseClone();

        var settings = new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.All};
        var objectAsJson = JsonConvert.SerializeObject(this, typeof(Manager), settings);
        return JsonConvert.DeserializeObject<Person>(objectAsJson, settings);
    }
}
