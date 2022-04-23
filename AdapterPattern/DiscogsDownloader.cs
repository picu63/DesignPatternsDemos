namespace AdapterPattern;

public class DiscogsDownloader : ICoverDownloader
{
    public DiscogsDownloader()
    {
        HttpClient.BaseAddress = new Uri("https://api.discogs.com");
    }

    public HttpClient HttpClient { get; } = new();

    public FileInfo? DownloadCover(AlbumInfo albumInfo)
    {
        // implementation ...
        

        return new FileInfo($"{albumInfo.AlbumName}.discogs.jpg");
    }
}