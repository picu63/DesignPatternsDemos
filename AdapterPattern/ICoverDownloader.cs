namespace AdapterPattern;

public interface ICoverDownloader
{
    FileInfo? DownloadCover(AlbumInfo albumInfo);
}