namespace Module18.Patterns2.Task18;
/// <summary>
/// Запускать с приложением для обхода DPI. 
/// Например, GoodbyeDPI https://github.com/ValdikSS/GoodbyeDPI 
/// Или через VPN.
/// </summary>
public class Program
{
    public static async Task Main(string[] args)
    {
        var YoutubeDownloader = new YoutubeDownloader();
        Console.WriteLine("Введите ссылку на видео в Youtube: ");
        YoutubeDownloader.videoUrl = Console.ReadLine(); //https://www.youtube.com/watch?v=P4bKZT_Eg4A     
        if (String.IsNullOrEmpty(YoutubeDownloader.videoUrl) || YoutubeDownloader.videoUrl == "")
            YoutubeDownloader.videoUrl = "https://www.youtube.com/watch?v=P4bKZT_Eg4A";//для простоты отладки и проверки
        YoutubeDownloader.ffmpegPath = @".\ffmpeg\bin\ffmpeg.exe";
        YoutubeDownloader.outputPath = @".\output.mp4";
        
        // создадём отправителя
        var sender = new Sender();
                
        // создадём две команды
        var commandOne = new YoutubeDownloaderCommandLoadInfo(YoutubeDownloader);
        var commandTwo = new YoutubeDownloaderCommandDownloadVideo(YoutubeDownloader);

        // инициализация команды 1
        sender.SetCommand(commandOne);
        try
        {
            Console.WriteLine("Выполняется загрузка описания для видео... ");
            //  выполнение команды 1
            sender.Run();
        }
        catch (Exception ex1)
        {
            Console.WriteLine($"Ошибка: {ex1.Message}");
        }
        
        // инициализация команды 2
        sender.SetCommand(commandTwo);
        try
        {
            Console.WriteLine("Выполняется загрузка видео... ");
            //  выполнение команды 2
            sender.Run();
        }
        catch (Exception ex2)
        {
            Console.WriteLine($"Ошибка: {ex2.Message}");
        }
        
        Console.ReadKey();
    }
}







