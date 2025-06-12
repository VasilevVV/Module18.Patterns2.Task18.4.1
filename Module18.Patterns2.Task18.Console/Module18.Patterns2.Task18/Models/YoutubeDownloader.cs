using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Module18.Patterns2.Task18;

/// <summary>
/// (Адресат команды) 
/// Класс для работы с YoutubeExplode
/// </summary>
public class YoutubeDownloader
{
    public string videoUrl { get; set; }

    public string outputPath { get; set; }

    public string ffmpegPath { get; set; }

    private YoutubeClient youtubeClient = new YoutubeClient();
    /// <summary>
    /// Загрузить информацию о видео
    /// </summary>
    public async void LoadInfo()
    {
        var video = await youtubeClient.Videos.GetAsync(videoUrl);
        Console.WriteLine($"Название: {video.Title}");
        Console.WriteLine($"Продолжительность: {video.Duration}");
        Console.WriteLine($"Автор: {video.Author}");
        Console.WriteLine($"Описание: {video.Description}");
    }
    /// <summary>
    /// Загрузить видео
    /// </summary>
    public async void DownloadVideo()
    {
        var video = await youtubeClient.Videos.GetAsync(videoUrl);
        var progress = new Progress<double>();
        progress.ProgressChanged += (s, e) => Console.WriteLine($"Загружено: {e:P2}");
        var conversionRequest = new ConversionRequest(ffmpegPath, outputPath, Container.Mp4, ConversionPreset.UltraFast);
        await youtubeClient.Videos.DownloadAsync(video.Id, conversionRequest, progress);
    }
}
