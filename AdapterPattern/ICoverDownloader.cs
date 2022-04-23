namespace AdapterPattern;

public interface ICoverDownloader
{
    public HttpClient HttpClient { get; }
    FileInfo? DownloadCover(AlbumInfo albumInfo);
}