namespace Module18.Patterns2.Task18;

/// <summary>
/// Команда на получение информации о Youtube-видео.
/// </summary>
public class YoutubeDownloaderCommandLoadInfo : Command
{
    private YoutubeDownloader youtubeDownloader;

    public YoutubeDownloaderCommandLoadInfo(YoutubeDownloader youtubeDownloader)
    {
        this.youtubeDownloader = youtubeDownloader;
    }

    // Выполнить
    public override void Run()
    {
        youtubeDownloader.LoadInfo();
    }

    // Отменить
    public override void Cancel()
    { }
}
