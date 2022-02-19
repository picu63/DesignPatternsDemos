public class Committer
{
    private HashSet<string> filesStaged = new();

    public void StageFiles(IList<string> filePaths)
    {
        foreach (var filePath in filePaths)
        {
            filesStaged.Add(filePath);
        }
    }

    public void Restore(Commit commit)
    {
        filesStaged = new HashSet<string>(commit.FilesStaged);
    }

    public Commit Run(string message)
    {
        return new Commit(message, filesStaged);
    }
}