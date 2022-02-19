public class Git
{
    public Git(Committer committer)
    {
        this.committer = committer;
    }
    private IList<Commit> commits = new List<Commit>();
    private Committer committer;

    public void Commit(string message)
    {
        Console.WriteLine($"Creating commit with message: {message}");
        this.commits.Add(committer.Run(message));
    }

    public void ResetLast()
    {
        if (this.commits.Count == 0)
        {
            return;
        }

        var memento = this.commits.Last();
        this.commits.Remove(memento);

        Console.WriteLine("Resetting last commit...");

        try
        {
            this.committer.Restore(memento);
        }
        catch (Exception)
        {
            this.ResetLast();
        }
    }

    public void ShowHistory()
    {
        Console.WriteLine("Caretaker: Here's the list of history:");

        foreach (var commit in this.commits)
        {
            Console.WriteLine(commit.Message);
        }
    }
}