namespace AdapterPattern;

public class DiscogsDownloader : ICoverDownloader
{
    public DiscogsDownloader()
    {
        httpClient.BaseAddress = new Uri("https://api.discogs.com");
    }
    private readonly HttpClient httpClient = new();
    public FileInfo? DownloadCover(AlbumInfo albumInfo)
    {
        // implementation ...
        

        return new FileInfo($"{albumInfo.AlbumName}.discogs.jpg");
    }
}