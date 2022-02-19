public class Commit
{
    public string Message { get; }
    public ICollection<string> FilesStaged { get; }

    public Commit(string message, ICollection<string> filesStaged)
    {
        Message = message;
        FilesStaged = filesStaged;
    }
}