namespace MementoPattern;

public class Stager
{
    public List<string> FilesStaged { get; private set; } = new();

    public void Stage(List<string> filePaths)
    {
        Console.WriteLine("Staging files...");
        var filesToStage = filePaths.Except(FilesStaged).ToList();
        FilesStaged.AddRange(filesToStage);
        Console.WriteLine($"{filesToStage.Count} files was staged.");
    }

    public void Unstage(List<string> filePaths)
    {
        foreach (var filePath in filePaths.Where(filePath => FilesStaged.Contains(filePath)))
        {
            Console.WriteLine($"Removing {filePath} from staged files...");
            FilesStaged.Remove(filePath);
            Console.WriteLine($"{filePath} was removed from staged files.");
        }
    }

    // Saves the current chapter inside a memento.
    public IMemento<List<string>> Save()
    {
        return new StageMomento(FilesStaged);
    }

    // Restores the Originator's state from a memento object.
    public void Restore(IMemento<List<string>> memento)
    {
        if (!(memento is StageMomento))
        {
            throw new Exception("Unknown memento class " + memento);
        }

        this.FilesStaged = memento.GetState();
        Console.Write($"{nameof(Stager)}: Current stage has changed to: {memento.GetName()}");
    }
}

public record Commit(Guid CommitGuid, string Message);

public class StageMomento : IMemento<List<string>>
{
    private readonly List<string> files;
    private readonly DateTime dateTime;

    public StageMomento(List<string> files)
    {
        this.files = files;
        this.dateTime = DateTime.Now;
    }

    public string GetName()
    {
        return $"{this.dateTime} / ({files.Count}) files";
    }

    public List<string> GetState() => files;

    public DateTime GetDate()
    {
        return this.dateTime;
    }
}

public interface IMemento<out TState> //Inaczej snapshot
{
    string GetName();

    TState GetState();

    DateTime GetDate();
}

