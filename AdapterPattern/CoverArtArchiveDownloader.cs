namespace AdapterPattern;

public class CoverArtArchiveDownloader : ICoverDownloader
{
    public CoverArtArchiveDownloader()
    {
        httpClient.BaseAddress = new Uri("https://coverartarchive.org");
    }

    private readonly HttpClient httpClient = new();
    public FileInfo? DownloadCover(AlbumInfo albumInfo)
    {
        // implementation ...


        return new FileInfo($"{albumInfo.AlbumName}.coverartarchive.jpg");
    }
}