namespace AdapterPattern;

public class LocalCoverDownloader : ICoverDownloader
{
    private readonly LocalCoverSearcher localCoverSearcher;

    public LocalCoverDownloader(LocalCoverSearcher localCoverSearcher)
    {
        this.localCoverSearcher = localCoverSearcher;
    }

    public HttpClient HttpClient => null!; // Not usable in this downloader

    public FileInfo? DownloadCover(AlbumInfo albumInfo)
    {
        return localCoverSearcher.FindCover(albumInfo);
    }
}