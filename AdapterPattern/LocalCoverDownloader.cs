namespace AdapterPattern;

public class LocalCoverDownloader : ICoverDownloader
{
    private readonly LocalCoverSearcher localCoverSearcher;

    public LocalCoverDownloader(LocalCoverSearcher localCoverSearcher)
    {
        this.localCoverSearcher = localCoverSearcher;
    }

    public FileInfo? DownloadCover(AlbumInfo albumInfo)
    {
        return localCoverSearcher.FindCover(albumInfo);
    }
}