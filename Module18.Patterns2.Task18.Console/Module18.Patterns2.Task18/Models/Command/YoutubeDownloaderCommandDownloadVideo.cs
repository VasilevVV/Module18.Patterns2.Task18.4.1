namespace Module18.Patterns2.Task18;

/// <summary>
/// Команда на загрузку Youtube-видео.
/// </summary>
public class YoutubeDownloaderCommandDownloadVideo : Command
{
    private YoutubeDownloader youtubeDownloader;

    public YoutubeDownloaderCommandDownloadVideo(YoutubeDownloader youtubeDownloader)
    {
        this.youtubeDownloader = youtubeDownloader;
    }

    // Выполнить
    public override void Run()
    {
        youtubeDownloader.DownloadVideo();
    }

    // Отменить
    public override void Cancel()
    { }
}
