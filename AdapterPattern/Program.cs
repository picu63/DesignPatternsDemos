using AdapterPattern;

CoverProvider coverProvider = new CoverProvider();
ICoverDownloader discogsDownloader = new DiscogsDownloader();
coverProvider.CoverDownloaders.Add(discogsDownloader);
ICoverDownloader coverArtArchiveDownloader = new CoverArtArchiveDownloader();
coverProvider.CoverDownloaders.Add(coverArtArchiveDownloader);
// CoverProvider is prepared to download a covers not getting them from local source -
// - you are not downloading cover from that source, but your system not allowed you to change that.
// In LocalCoverDownloader we are injecting LocalCoverSearcher to use that in structure of coverDownloaders
ICoverDownloader localCoverDownloader = new LocalCoverDownloader(new LocalCoverSearcher("C:\\"));
coverProvider.CoverDownloaders.Add(localCoverDownloader);

var michaelJacksonCoverFiles = coverProvider.GetCoverFiles(new AlbumInfo("Michael Jackson", "Bad"));
michaelJacksonCoverFiles.ForEach(f =>
{
    if (f is not null)
        Console.WriteLine(f.DirectoryName + Path.DirectorySeparatorChar + f.Name);
    Console.WriteLine("Cover not found");
});
Console.ReadKey();