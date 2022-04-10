namespace AdapterPattern;

public class LocalCoverSearcher
{
    private readonly string directoryPath;
    private readonly bool includeSubdirectories;

    public LocalCoverSearcher(string directoryPath, bool includeSubdirectories = true)
    {
        this.directoryPath = directoryPath;
        this.includeSubdirectories = includeSubdirectories;
    }
    public FileInfo? FindCover(AlbumInfo albumInfo)
    {
        var filePath = Directory.EnumerateFiles(directoryPath,
                $"*{albumInfo.AlbumName}*",
                includeSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
            .FirstOrDefault();
        return string.IsNullOrEmpty(filePath) ? null : new FileInfo(filePath);
    }
}