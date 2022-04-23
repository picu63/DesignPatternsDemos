namespace AdapterPattern;

public class CoverArtArchiveDownloader : ICoverDownloader
{
    public CoverArtArchiveDownloader()
    {
        HttpClient.BaseAddress = new Uri("https://coverartarchive.org");
    }

    public HttpClient HttpClient { get; } = new();

    public FileInfo? DownloadCover(AlbumInfo albumInfo)
    {
        // implementation ...


        return new FileInfo($"{albumInfo.AlbumName}.coverartarchive.jpg");
    }
}