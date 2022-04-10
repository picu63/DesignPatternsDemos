namespace AdapterPattern;

public class CoverProvider
{
    public List<ICoverDownloader> CoverDownloaders { get; } = new();

    public List<FileInfo?> GetCoverFiles(AlbumInfo albumInfo)
    {
        return CoverDownloaders
            .Select(coverDownloader => coverDownloader.DownloadCover(albumInfo))
            .ToList();
    }
}